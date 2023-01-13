using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form08 : Form
    {
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form17 form17;
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private string dataFormName;
        private int[] element;
        private SortedSet<Tuple<int, int>> equation;
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> equations;
        private bool generateClicked = false;
        private int numOfEquations;
        private string output;
        private string problemName;
        private string result;
        private SortedSet<Tuple<int, int>> vertexes;
        public Form08(Form17 form17)
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
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> FillEquations(int numOfEquations, SortedDictionary<int, SortedSet<Tuple<int, int>>> equations)
        {
            Random random = new Random();
            for (int i = 0; i < numOfEquations; i++)
            {
                element = new int[numOfEquations];
                for (int j = 0; j < numOfEquations; j++)
                {
                    element[j] = random.Next(0, 2);
                }
                equation = new SortedSet<Tuple<int, int>>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        Tuple<int, int> argument = new Tuple<int, int>(j, random.Next(0, numOfEquations));
                        equation.Add(argument);
                    }
                }
                equations.Add(i, equation);
            }
            return equations;
        }
        private SortedSet<Tuple<int, int>> FillEquationsVertexesWeights(int numOfEquations, SortedSet<Tuple<int, int>> vertexes)
        {
            Random random = new Random();
            for (int i = 0; i < numOfEquations; i++)
            {
                Tuple<int, int> vertex = new Tuple<int, int>(i, random.Next(0, numOfEquations));
                vertexes.Add(vertex);
            }
            return vertexes;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(Size.Text) > 1)
            {
                numOfEquations = Convert.ToInt32(Size.Text);
                equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
                FillEquations(numOfEquations, equations);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillEquationsVertexesWeights(numOfEquations, vertexes);
                ShowEquations(equations);
                generateClicked = true;
            }
            else
            {
                MessageBox.Show("Size should be > 1");
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true)
            {
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
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (generateClicked == true)
            {
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
        private void ShowEquations(SortedDictionary<int, SortedSet<Tuple<int, int>>> equations)
        {
            output = "";
            if (equations.Count > 100)
            {
                output += "data is too big. Please save it to watch.";
            }
            else
            {
                foreach (KeyValuePair<int, SortedSet<Tuple<int, int>>> equation in equations)
                {
                    output += "f_" + (equation.Key + 1).ToString() + " = (   ";
                    foreach (Tuple<int, int> argument in equation.Value)
                    {
                        output += argument.Item2 + "x_" + (argument.Item1 + 1) + "   ";
                    }
                    output += ")\n";
                }
                output += "\n";
                foreach (Tuple<int, int> vertex in vertexes)
                {
                    output += "v_" + (vertex.Item1 + 1).ToString() + " - w_" + (vertex.Item2).ToString() + "\n";
                }
            }
            Data.Text = output;
        }
        private void Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
