using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form07 : Form
    {
        readonly Form17 form17;
        private string[] argumentFromFile;
        private HashSet<int> argumentsFromFile;
        private bool chooseFileClicked = false;
        private string[] elementInRow;
        private SortedDictionary<int, HashSet<int>> equations;
        private string fileData;
        private string fileName;
        private int functionFromFile;
        private int numOfEquations;
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
            Form06 form06 = new Form06();
            form06.ShowDialog();
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            File.Text = fileName;
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
                    numOfEquations = fileData.Split('\n').Length;
                    equations = new SortedDictionary<int, HashSet<int>>();
                    FillEquations(numOfEquations, equations);
                    Form.ActiveForm.Visible = false;
                    form17.SendData(equations);
                    form17.ShowDialog();
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
    }
}
