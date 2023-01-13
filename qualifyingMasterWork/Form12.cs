using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form12 : Form
    {
        readonly Form11 form11;
        readonly Form12 form12;
        readonly Form13 form13;
        readonly Form20 form20;
        readonly Form21 form21;
        readonly Form22 form22;
        readonly Form23 form23;
        private string dataFormName;
        private SortedSet<Tuple<int, int, int>> commutativeDiagram;
        private bool generateClicked = false;
        private int numOfVertexesInEachPart;
        private string output;
        private string problemName;
        private string result;
        private SortedSet<Tuple<int, int>> vertexes;
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public Form12(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form10 form10 = new Form10(form11, form12, form13);
            form10.SendDataForm(dataFormName);
            form10.SendProblem(problemName);
            form10.ShowDialog();
        }
        private SortedSet<Tuple<int, int, int>> FillCommutativeDiagram(int numOfVertexesInEachPart, SortedSet<Tuple<int, int, int>> commutativeDiagram)
        {
            Random random = new Random();
            for (int i = 0; i < numOfVertexesInEachPart; i++)
            {
                int[] element = new int[numOfVertexesInEachPart];
                for (int j = 0; j < numOfVertexesInEachPart; j++)
                {
                    element[j] = random.Next(0, 2);
                    if (element[j] == 1)
                    {
                        Tuple<int, int, int> edge = new Tuple<int, int, int>(i, j, random.Next(0, numOfVertexesInEachPart));
                        commutativeDiagram.Add(edge);
                    }
                }
            }
            return commutativeDiagram;
        }
        private SortedSet<Tuple<int, int>> FillCommutativeDiagramVertexesWeights(int numOfVertexesInEachPart, SortedSet<Tuple<int, int>> vertexes)
        {
            Random random = new Random();
            for (int i = 0; i < numOfVertexesInEachPart; i++)
            {
                Tuple<int, int> vertex = new Tuple<int, int>(i, random.Next(0, numOfVertexesInEachPart));
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
                numOfVertexesInEachPart = Convert.ToInt32(Size.Text);
                commutativeDiagram = new SortedSet<Tuple<int, int, int>>();
                FillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillCommutativeDiagramVertexesWeights(numOfVertexesInEachPart, vertexes);
                this.Controls.Remove(viewer);
                ShowCommutativeDiagram(commutativeDiagram);
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
                        Form21 form21_ = new Form21(form23);
                        form21_.SendData(commutativeDiagram);
                        form21_.SendDataForm(dataFormName);
                        form21_.SendDataVertexesWeights(vertexes);
                        form21_.SendProblem(problemName);
                        form21_.ShowDialog();
                        break;
                    case "Finding probabilities of system states":
                        Form.ActiveForm.Visible = false;
                        Form22 form22_ = new Form22(form23);
                        form22_.SendData(commutativeDiagram);
                        form22_.SendDataForm(dataFormName);
                        form22_.SendDataVertexesWeights(vertexes);
                        form22_.SendProblem(problemName);
                        form22_.ShowDialog();
                        break;
                    case "Finding the minimum weight spanning tree":
                        Form.ActiveForm.Visible = false;
                        Form23 form23_ = new Form23();
                        form23_.SendDataForm(dataFormName);
                        form23_.SendDataVertexesWeights(vertexes);
                        form23_.SendCommutativeDiagramData(commutativeDiagram);
                        form23_.SendProblem(problemName);
                        form23_.ShowDialog();
                        break;
                    case "skip":
                        Form.ActiveForm.Visible = false;
                        Form20 form20 = new Form20(form21, form22);
                        form20.SendData(commutativeDiagram);
                        form20.SendDataVertexesWeights(vertexes);
                        form20.SendProblem(problemName);
                        form20.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please generate data");
            }
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
        private void Save_Click(object sender, EventArgs e)
        {
            if (generateClicked == true)
            {
                if (SaveFile.ShowDialog() == DialogResult.Cancel)
                    return;
                SaveCommutativeDiagram(commutativeDiagram);
                string filename = SaveFile.FileName;
                System.IO.File.WriteAllText(filename, result);
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
            viewer.Location = new System.Drawing.Point(250, 0);
            viewer.Size = new System.Drawing.Size(350, 300);
            this.SuspendLayout();
            this.Controls.Add(viewer);
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
