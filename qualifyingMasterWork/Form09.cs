using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form09 : Form
    {
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form17 form17;
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private string[] argumentFromTextbox;
        private SortedSet<Tuple<int, int>> argumentsFromTextbox;
        private string dataFormName;
        private string[] equationFromTextbox;
        private int functionFromTextbox;
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> equations;
        private int numOfEquations;
        private string problemName;
        private string[] elementInRow;
        public Form09(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06(form07, form08, form09);
            form06.SendDataForm(dataFormName);
            form06.SendProblem(problemName);
            form06.ShowDialog();
        }
        private bool CheckDataFromManualInput()
        {
            numOfEquations = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';').Length;
            string[] equation = new string[numOfEquations];
            equation = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';');
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
        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8)
                && e.KeyChar != Convert.ToChar(13) && e.KeyChar != Convert.ToChar(32) && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(45) && e.KeyChar != Convert.ToChar(46) && e.KeyChar != Convert.ToChar(58)
                && e.KeyChar != Convert.ToChar(59))
            {
                e.Handled = true;
            }
        }
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> FillEquations(int numOfEquations, SortedDictionary<int, SortedSet<Tuple<int, int>>> equations)
        {
            equationFromTextbox = new string[numOfEquations];
            equationFromTextbox = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';');
            for (int i = 0; i < numOfEquations; i++)
            {
                var charsToRemove = new string[] { " ", "." };
                string equationElements = equationFromTextbox[i];
                foreach (var c in charsToRemove)
                {
                    equationElements = equationElements.Replace(c, string.Empty);
                }
                equationElements = Regex.Replace(equationElements, "[A-Za-z]", string.Empty);
                equationElements = equationElements.Replace(Environment.NewLine, string.Empty);
                elementInRow = equationElements.Split(':');
                functionFromTextbox = Convert.ToInt32(elementInRow[0].Substring(elementInRow[0].IndexOf('_') + 1)) - 1;
                argumentsFromTextbox = new SortedSet<Tuple<int, int>>();
                argumentFromTextbox = elementInRow[1].Split(',');
                for (int j = 0; j < argumentFromTextbox.Length; j++)
                {
                    Tuple<int, int> argument = new Tuple<int, int>(Convert.ToInt32(argumentFromTextbox[j].Substring(argumentFromTextbox[j].IndexOf('_') + 1)) - 1, Convert.ToInt32(argumentFromTextbox[j].Substring(0, argumentFromTextbox[j].IndexOf('_'))));
                    argumentsFromTextbox.Add(argument);
                }
                equations.Add(functionFromTextbox, argumentsFromTextbox);
            }
            return equations;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
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
