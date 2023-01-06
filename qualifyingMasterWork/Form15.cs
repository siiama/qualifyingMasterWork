using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form15 : Form
    {
        private string dataFormName;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> equations;
        private int[,] matrix;
        private int numOfEquations;
        private string output;
        private string problemName;
        private string result;
        private SortedSet<Tuple<int, int>> vertexes;
        public Form15(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> FillEquations(int numOfEquations, SortedDictionary<int, SortedSet<Tuple<int, int>>> equations)
        {
            for (int i = 0; i < numOfEquations; i++)
            {
                int[] element = new int[numOfEquations];
                for (int j = 0; j < numOfEquations; j++)
                {
                    element[j] = matrix[i, j];
                }
                SortedSet<Tuple<int, int>> equation = new SortedSet<Tuple<int, int>>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] != -1)
                    {
                        Tuple<int, int> argument = new Tuple<int, int>(j, element[j]);
                        equation.Add(argument);
                    }
                }
                equations.Add(i, equation);
            }
            return equations;
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            switch (problemName)
            {
                case "skip":
                    Form.ActiveForm.Visible = false;
                    break;
                default:
                    Form.ActiveForm.Visible = false;
                    Form23 form23 = new Form23();
                    form23.SendDataForm(dataFormName);
                    form23.SendDataVertexesWeights(vertexes);
                    form23.SendSystemOfEquationsData(equations);
                    form23.SendProblem(problemName);
                    form23.ShowDialog();
                    break;
            }
        }
        private void Form15_Load(object sender, EventArgs e)
        {
            numOfEquations = matrix.GetLength(0);
            equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
            FillEquations(numOfEquations, equations);
            ShowEquations(equations);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveEquations(equations);
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
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
        public void SendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
        }
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendDataVertexesWeights(SortedSet<Tuple<int, int>> dataVertexes)
        {
            vertexes = dataVertexes;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
        private void ShowEquations(SortedDictionary<int, SortedSet<Tuple<int, int>>> equations)
        {
            output = "";
            foreach (KeyValuePair<int, SortedSet<Tuple<int, int>>> equation in equations)
            {
                output += "f_" + (equation.Key + 1).ToString() + " = (   ";
                foreach (Tuple<int, int> argument in equation.Value)
                {
                    output += argument.Item2 + " x_" + (argument.Item1 + 1) + "   ";
                }
                output += ")\n";
            }
            output += "\n";
            foreach (Tuple<int, int> vertex in vertexes)
            {
                output += "v_" + (vertex.Item1 + 1).ToString() + ", w_" + (vertex.Item2).ToString() + ";\n";
            }
            Data.Text = output;
        }
    }
}
