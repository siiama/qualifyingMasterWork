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
        private string result;
        private string[] elementInRow;
        private SortedSet<Tuple<int, int>> vertexes;
        private Tuple<int, int> vertexFromTextbox;
        private string[] vertexesFromTextbox;
        private string[] weightsOfVertexes;
        public Form09(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
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
            bool wrongFunctionBeforeColon = false;
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
                if ((equationElements.Split(':')[0].Split(',').Length > 1))
                {
                    wrongFunctionBeforeColon = true;
                }
            }
            if (numOfEquations < maxNumOfElements)
            {
                MessageBox.Show("Number of equations can not be less then number of variables!");
                return false;
            }
            else if (wrongFunctionBeforeColon)
            {
                MessageBox.Show("Each equation must have one function!");
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
                && e.KeyChar != Convert.ToChar(46) && e.KeyChar != Convert.ToChar(58) && e.KeyChar != Convert.ToChar(59))
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
        private SortedSet<Tuple<int, int>> FillEquationsVertexesWeights(SortedSet<Tuple<int, int>> vertexes)
        {
            vertexesFromTextbox = Data.Text.Substring(Data.Text.IndexOf('.')).Split(';');
            if (vertexesFromTextbox.Length == numOfEquations)
            {
                for (int i = 0; i < vertexesFromTextbox.Length; i++)
                {
                    string vertexesWeigths = vertexesFromTextbox[i];
                    var charsToRemove = new string[] { " ", ".", "_" };
                    foreach (var c in charsToRemove)
                    {
                        vertexesWeigths = vertexesWeigths.Replace(c, string.Empty);
                    }
                    vertexesWeigths = Regex.Replace(vertexesWeigths, "[A-Za-z]", string.Empty);
                    vertexesWeigths = vertexesWeigths.Replace(Environment.NewLine, string.Empty);
                    weightsOfVertexes = vertexesWeigths.Split(',');
                    vertexFromTextbox = new Tuple<int, int>(Convert.ToInt32(weightsOfVertexes[0]) - 1, Convert.ToInt32(weightsOfVertexes[1]));
                    vertexes.Add(vertexFromTextbox);
                }
            }
            else
            {
                vertexes.Clear();
                for (int i = 0; i < numOfEquations; i++)
                {
                    vertexes.Add(new Tuple<int, int>(i, 0));
                }
                MessageBox.Show("You did not provide vertexes weights\nso they all will be 0");
            }
            return vertexes;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
                FillEquations(numOfEquations, equations);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillEquationsVertexesWeights(vertexes);
                switch (problemName)
                {
                    case "Finding the shortest path":
                        Form.ActiveForm.Visible = false;
                        Form18 form18_ = new Form18(form23);
                        form18_.SendData(equations);
                        form18_.SendDataForm(dataFormName);
                        form18_.SendDataVertexesWeights(vertexes);
                        form18_.SendProblem(problemName);
                        form18_.ShowDialog();
                        break;
                    case "Finding probabilities of system states":
                        Form.ActiveForm.Visible = false;
                        Form23 form23_ = new Form23();
                        form23_.SendSystemOfEquationsData(equations);
                        form23_.SendDataForm(dataFormName);
                        form23_.SendDataVertexesWeights(vertexes);
                        form23_.SendProblem(problemName);
                        form23_.ShowDialog();
                        break;
                    case "Finding the minimum weight spanning tree":
                        Form.ActiveForm.Visible = false;
                        Form19 form19_ = new Form19(form23);
                        form19_.SendData(equations);
                        form19_.SendDataForm(dataFormName);
                        form19_.SendDataVertexesWeights(vertexes);
                        form19_.SendProblem(problemName);
                        form19_.ShowDialog();
                        break;
                    case "skip":
                        Form.ActiveForm.Visible = false;
                        Form17 form17 = new Form17(form18, form19);
                        form17.SendData(equations);
                        form17.SendDataVertexesWeights(vertexes);
                        form17.SendProblem(problemName);
                        form17.ShowDialog();
                        break;
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
                FillEquations(numOfEquations, equations);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillEquationsVertexesWeights(vertexes);
                if (SaveFile.ShowDialog() == DialogResult.Cancel)
                    return;
                SaveEquations(equations);
                string filename = SaveFile.FileName;
                System.IO.File.WriteAllText(filename, result);
            }
        }
        private void SaveEquations(SortedDictionary<int, SortedSet<Tuple<int, int>>> equations)
        {
            result = "";
            foreach (KeyValuePair<int, SortedSet<Tuple<int, int>>> equation in equations)
            {
                result += "f_" + (equation.Key + 1).ToString() + ": ";
                foreach (Tuple<int, int> argument in equation.Value)
                {
                    result += argument.Item2 + " x_" + (argument.Item1 + 1) + ", ";
                }
                result = result.Remove(result.Length - 2);
                result += ";\n";
            }
            result = result.Remove(result.Length - 2);
            result += ".";
            result += "\n";
            foreach (Tuple<int, int> vertex in vertexes)
            {
                result += "v_" + (vertex.Item1 + 1).ToString() + ", w_" + (vertex.Item2).ToString() + ";\n";
            }
            result = result.Remove(result.Length - 2);
            result += ".";
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
