using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form22 : Form
    {
        readonly Form23 form23;
        private string dataFormName;
        private SortedSet<Tuple<int, int, int>> commutativeDiagram;
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> equations;
        private int numOfVertexesInEachPart;
        private string output;
        private string problemName;
        private string result;
        private long time;
        private SortedSet<Tuple<int, int>> vertexes;
        public Form22(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> FillEquations(int numOfVertexesInEachPart, SortedDictionary<int, SortedSet<Tuple<int, int>>> equations)
        {
            for (int i = 0; i < numOfVertexesInEachPart; i++)
            {
                SortedSet<Tuple<int, int>> equation = new SortedSet<Tuple<int, int>>();
                foreach (Tuple<int, int, int> edge in commutativeDiagram)
                {
                    if (edge.Item1 == i)
                    {
                        Tuple<int, int> argument = new Tuple<int, int>(edge.Item2, edge.Item3);
                        equation.Add(argument);
                    }
                }
                if (equation.Count != 0)
                {
                    equations.Add(i, equation);
                }
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
                    form23.SendTime(time);
                    form23.ShowDialog();
                    break;
            }
        }
        private void Form22_Load(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            numOfVertexesInEachPart = commutativeDiagram.Max(v => v.Item1) + 1;
            equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
            FillEquations(numOfVertexesInEachPart, equations);
            stopwatch.Stop();
            time = stopwatch.ElapsedMilliseconds;
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
        public void SendData(SortedSet<Tuple<int, int, int>> data)
        {
            commutativeDiagram = new SortedSet<Tuple<int, int, int>>();
            commutativeDiagram = data;
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
                        output += argument.Item2 + " x_" + (argument.Item1 + 1) + "   ";
                    }
                    output += ")\n";
                }
                output += "\n";
                foreach (Tuple<int, int> vertex in vertexes)
                {
                    output += "v_" + (vertex.Item1 + 1).ToString() + ", w_" + (vertex.Item2).ToString() + ";\n";
                }
            }
            Data.Text = output;
        }
    }
}
