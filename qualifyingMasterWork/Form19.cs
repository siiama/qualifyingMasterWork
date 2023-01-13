using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form19 : Form
    {
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private string dataFormName;
        private SortedSet<Tuple<int, int, int>> commutativeDiagram;
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> equations;
        private string output;
        private string problemName;
        private string result;
        private SortedSet<Tuple<int, int>> vertexes;
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public Form19(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private SortedSet<Tuple<int, int, int>> FillCommutativeDiagram(SortedSet<Tuple<int, int, int>> commutativeDiagram)
        {
            foreach (KeyValuePair<int, SortedSet<Tuple<int, int>>> equation in equations)
            {
                int function = equation.Key;
                foreach (Tuple<int, int> argument in equation.Value)
                {
                    Tuple<int, int, int> edge = new Tuple<int, int, int>(function, argument.Item1, argument.Item2);
                    commutativeDiagram.Add(edge);
                }
            }
            return commutativeDiagram;
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
                    form23.SendCommutativeDiagramData(commutativeDiagram);
                    form23.SendProblem(problemName);
                    form23.ShowDialog();
                    break;
            }
        }
        private void Form19_Load(object sender, EventArgs e)
        {
            commutativeDiagram = new SortedSet<Tuple<int, int, int>>();
            FillCommutativeDiagram(commutativeDiagram);
            this.Controls.Remove(viewer);
            ShowCommutativeDiagram(commutativeDiagram);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveCommutativeDiagram(commutativeDiagram);
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void SaveCommutativeDiagram(SortedSet<Tuple<int, int, int>> commutativeDiagram)
        {
            result = "";
            foreach (Tuple<int, int, int> edge in commutativeDiagram)
            {
                result += "g_" + (edge.Item1 + 1) + ", x_" + (edge.Item2 + 1) + ", w_" + edge.Item3 + ";\n";
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
        public void SendData(SortedDictionary<int, SortedSet<Tuple<int, int>>> data)
        {
            equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
            equations = data;
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
        private void ShowCommutativeDiagram(SortedSet<Tuple<int, int, int>> commutativeDiagram)
        {
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach (Tuple<int, int, int> edge in commutativeDiagram)
            {
                graph.AddEdge("g_" + Convert.ToString(edge.Item1 + 1), "x_" + Convert.ToString(edge.Item2 + 1)).LabelText = Convert.ToString(edge.Item3);
                Microsoft.Msagl.Drawing.Node g = graph.FindNode("g_" + Convert.ToString(edge.Item1 + 1));
                g.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MintCream;
                Microsoft.Msagl.Drawing.Node x = graph.FindNode("x_" + Convert.ToString(edge.Item2 + 1));
                x.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MintCream;
            }
            viewer.Graph = graph;
            viewer.Location = new System.Drawing.Point(200, 0);
            viewer.Size = new System.Drawing.Size(350, 300);
            this.SuspendLayout();
            this.Controls.Add(viewer);
        }
    }
}
