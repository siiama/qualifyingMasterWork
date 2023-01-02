using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form07 : Form
    {
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form17 form17;
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private string dataFormName;
        private string[] argumentFromFile;
        private HashSet<int> argumentsFromFile;
        private bool chooseFileClicked = false;
        private string[] elementInRow;
        private SortedDictionary<int, HashSet<int>> equations;
        private string fileData;
        private string fileName;
        private int functionFromFile;
        private int numOfEquations;
        private string problemName;
        private string[] equationFromFile;
        public Form07(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06(form07, form08, form09);
            form06.SendDataForm(dataFormName);
            form06.SendProblem(problemName);
            form06.ShowDialog();
        }
        private bool CheckDataFromFile()
        {
            numOfEquations = fileData.Substring(0, fileData.IndexOf('.')).Split(';').Length;
            string[] equation = new string[numOfEquations];
            equation = fileData.Substring(0, fileData.IndexOf('.')).Split(';');
            int maxNumOfElements = 0;
            for (int i = 0; i < equation.Length; i++)
            {
                var charsToRemove = new string[] { " ", ".", "_" };
                string equationElements = equation[i];
                foreach (var c in charsToRemove)
                {
                    equationElements = equationElements.Replace(c, string.Empty);
                }
                equationElements = Regex.Replace(equationElements, "[A-Za-z]", string.Empty);
                equationElements = equationElements.Replace(Environment.NewLine, string.Empty);
                if ((equationElements.Split(':')[1].Split(',').Length) > maxNumOfElements)
                {
                    maxNumOfElements = equationElements.Split(':')[1].Split(',').Length;
                }
            }
            if (numOfEquations < maxNumOfElements)
            {
                MessageBox.Show("Number of equations can not be less then number of variables!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            File.Text = System.IO.Path.GetFileName(fileName);
            chooseFileClicked = true;
        }
        private SortedDictionary<int, HashSet<int>> FillEquations(int numOfEquations, SortedDictionary<int, HashSet<int>> equations)
        {
            equationFromFile = new string[numOfEquations];
            equationFromFile = fileData.Split('\n');
            for (int i = 0; i < equationFromFile.Length; i++)
            {
                elementInRow = equationFromFile[i].Split(':');
                functionFromFile = Convert.ToInt32(elementInRow[0].Substring(elementInRow[0].IndexOf('f') + 2)) - 1;
                argumentsFromFile = new HashSet<int>();
                argumentFromFile = elementInRow[1].Split(' ');
                for (int j = 0; j < argumentFromFile.Length; j++)
                {
                    argumentsFromFile.Add(Convert.ToInt32(argumentFromFile[j].Substring(argumentFromFile[j].IndexOf('x') + 2)) - 1);
                }
                equations.Add(functionFromFile, argumentsFromFile);
            }
            return equations;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    if (CheckDataFromFile())
                    {
                        numOfEquations = fileData.Split('\n').Length;
                        equations = new SortedDictionary<int, HashSet<int>>();
                        FillEquations(numOfEquations, equations);
                        switch (problemName)
                        {
                            case "Finding the shortest path":
                                Form.ActiveForm.Visible = false;
                                Form18 form18_ = new Form18(form23);
                                form18_.SendData(equations);
                                form18_.SendDataForm(dataFormName);
                                form18_.SendProblem(problemName);
                                form18_.ShowDialog();
                                break;
                            case "Finding probabilities of system states":
                                Form.ActiveForm.Visible = false;
                                Form23 form23_ = new Form23();
                                form23_.SendSystemOfEquationsData(equations);
                                form23_.SendDataForm(dataFormName);
                                form23_.SendProblem(problemName);
                                form23_.ShowDialog();
                                break;
                            case "Finding the minimum weight spanning tree":
                                Form.ActiveForm.Visible = false;
                                Form19 form19_ = new Form19(form23);
                                form19_.SendData(equations);
                                form19_.SendDataForm(dataFormName);
                                form19_.SendProblem(problemName);
                                form19_.ShowDialog();
                                break;
                            case "skip":
                                Form.ActiveForm.Visible = false;
                                Form17 form17 = new Form17(form18, form19);
                                form17.SendData(equations);
                                form17.SendProblem(problemName);
                                form17.ShowDialog();
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Empty file");
                }
            }
            else
            {
                MessageBox.Show("Please choose file");
            }
        }
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
