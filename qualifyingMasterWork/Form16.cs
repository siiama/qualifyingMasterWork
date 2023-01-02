using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form16 : Form
    {
        private string dataFormName;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private SortedSet<Tuple<int, int>> commutativeDiagram;
        private int[,] matrix;
        private int numOfVertexesInEachPart;
        private string output;
        private string problemName;
        private string result;
        public Form16(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private SortedSet<Tuple<int, int>> FillCommutativeDiagram(int numOfVertexesInEachPart, SortedSet<Tuple<int, int>> commutativeDiagram)
        {
            for (int i=0; i<numOfVertexesInEachPart; i++)
            {
                for (int j=0; j<numOfVertexesInEachPart; j++)
                {
                    if (matrix[i,j] == 1)
                    {
                        Tuple<int, int> edge = new Tuple<int, int>(i, j);
                        commutativeDiagram.Add(edge);
                    }
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
                    form23.SendCommutativeDiagramData(commutativeDiagram);
                    form23.SendProblem(problemName);
                    form23.ShowDialog();
                    break;
            }
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            numOfVertexesInEachPart = matrix.GetLength(0);
            commutativeDiagram = new SortedSet<Tuple<int, int>>();
            FillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
            ShowCommutativeDiagram(commutativeDiagram);
        }
        private void SaveCommutativeDiagram(SortedSet<Tuple<int, int>> commutativeDiagram)
        {
            result = "";
            foreach (Tuple<int, int> edge in commutativeDiagram)
            {
                result += "g_" + (edge.Item1 + 1) + ", x_" + (edge.Item2 + 1) + ";\n";
            }
            result = result.Remove(result.Length - 2);
            result += ".";
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveCommutativeDiagram(commutativeDiagram);
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
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
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
        private void ShowCommutativeDiagram(SortedSet<Tuple<int, int>> commutativeDiagram)
        {
            Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach (Tuple<int, int> edge in commutativeDiagram)
            {
                graph.AddEdge("g_" + Convert.ToString(edge.Item1 + 1), "x_" + Convert.ToString(edge.Item2 + 1));
            }

            viewer.Graph = graph;
            this.SuspendLayout();
            this.Controls.Add(viewer);
        }
    }
}
