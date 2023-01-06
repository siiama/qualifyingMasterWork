using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form23 : Form
    {
        private string dataFormName;
        private SortedSet<Tuple<int, int, int>> commutativeDiagram;
        private int[,] matrix;
        private string problemName;
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> equations;
        public string result;
        private SortedSet<Tuple<int, int>> vertexes;
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        public Form23()
        {
            InitializeComponent();
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
        }
        public string SaveSolveFindingTheMinimumWeightSpanningTree(SortedSet<Tuple<int, int, int>> minimumSpanningTree)
        {
            /*result = "";
            foreach (Tuple<int, int, int> edge in minimumSpanningTree)
            {
                result += "g_" + (edge.Item1 + 1) + ", x_" + (edge.Item2 + 1) + ", w_" + edge.Item3 + ";\n";
            }
            result = result.Remove(result.Length - 2);
            result += ".";*/
            int sum = 0;
            foreach (Tuple<int, int, int> edge in minimumSpanningTree)
            {
                sum += edge.Item3;
            }
            return Convert.ToString(sum);
        }
        public void SendCommutativeDiagramData(SortedSet<Tuple<int, int, int>> commutativeDiagramData)
        {
            commutativeDiagram = commutativeDiagramData;
        }
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendDataVertexesWeights(SortedSet<Tuple<int, int>> dataVertexes)
        {
            vertexes = dataVertexes;
        }
        public void SendMatrixData(int[,] matrixData)
        {
            matrix = matrixData;
        }
        public void SendSystemOfEquationsData(SortedDictionary<int, SortedSet<Tuple<int, int>>> equationsData)
        {
            equations = equationsData;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
        public void ShowSolveFindingProbabilitiesOfSystemStates(SortedSet<Tuple<int, int, int>> minimumSpanningTree)
        {
            Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
            foreach (Tuple<int, int, int> edge in minimumSpanningTree)
            {
                graph.AddEdge(Convert.ToString(edge.Item1 + 1), Convert.ToString(edge.Item2 + 1)).LabelText = Convert.ToString(edge.Item3);
                Microsoft.Msagl.Drawing.Node g = graph.FindNode(Convert.ToString(edge.Item1 + 1));
                g.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MintCream;
                Microsoft.Msagl.Drawing.Node x = graph.FindNode(Convert.ToString(edge.Item2 + 1));
                x.Attr.FillColor = Microsoft.Msagl.Drawing.Color.MintCream;
            }
            viewer.Graph = graph;
            this.SuspendLayout();
            this.Controls.Add(viewer);
        }
        public string SolveFindingProbabilitiesOfSystemStates()
        {
            //system of equations
            //value of every vertex
            return result;
        }
        public SortedSet<Tuple<int, int, int>> SolveFindingTheMinimumWeightSpanningTree()
        {
            SortedSet<Tuple<int, int, int>> minimumSpanningTree = new SortedSet<Tuple<int, int, int>>();
            Random random = new Random();
            SortedSet<int> vertexes = new SortedSet<int>();
            foreach (Tuple<int, int, int> edge in commutativeDiagram)
            {
                vertexes.Add(edge.Item1);
            }
            int firstVertex = random.Next(vertexes.Min, vertexes.Max);
            SortedSet<int> vertexesFromSpanningTree = new SortedSet<int> { firstVertex };
            while (vertexesFromSpanningTree.Count != vertexes.Count)
            {
                SortedSet<Tuple<int, int, int>> edges = new SortedSet<Tuple<int, int, int>>();
                foreach (int vertex in vertexesFromSpanningTree)
                {
                    foreach (Tuple<int, int, int> edge in commutativeDiagram)
                    {
                        if (vertex == edge.Item1 && !vertexesFromSpanningTree.Contains(edge.Item2))
                        {
                            Tuple<int, int, int> potentialEdgeFromSpanningTree = new Tuple<int, int, int>(edge.Item1, edge.Item2, edge.Item3);
                            edges.Add(potentialEdgeFromSpanningTree);
                        }
                        if (vertex == edge.Item2 && !vertexesFromSpanningTree.Contains(edge.Item1))
                        {
                            Tuple<int, int, int> potentialEdgeFromSpanningTree = new Tuple<int, int, int>(edge.Item1, edge.Item2, edge.Item3);
                            edges.Add(potentialEdgeFromSpanningTree);
                        }
                    }
                }
                Tuple<int, int, int> edgeWithMinWeight = new Tuple<int, int, int>(-1,-1, int.MaxValue);
                foreach (Tuple<int, int, int> edge in edges)
                {
                    if (edge.Item3 < edgeWithMinWeight.Item3)
                    {
                        edgeWithMinWeight = edge;
                    }
                }
                if (!vertexesFromSpanningTree.Contains(edgeWithMinWeight.Item1))
                {
                    vertexesFromSpanningTree.Add(edgeWithMinWeight.Item1);
                    minimumSpanningTree.Add(edgeWithMinWeight);
                }
                if (!vertexesFromSpanningTree.Contains(edgeWithMinWeight.Item2))
                {
                    vertexesFromSpanningTree.Add(edgeWithMinWeight.Item2);
                    minimumSpanningTree.Add(edgeWithMinWeight);
                }
            }
            return minimumSpanningTree;
        }
        public string SolveFindingTheShortestPath()
        {
            //matrix
            //minimal way from every vertex to every other
            return result;
        }
        private void Form23_Load(object sender, EventArgs e)
        {
            Problem.Text = problemName;
            DataForm.Text = dataFormName;
            switch (problemName)
            {
                case "Finding the shortest path":
                    Solution.Text = SolveFindingTheShortestPath();
                    break;
                case "Finding probabilities of system states":
                    Solution.Text = SolveFindingProbabilitiesOfSystemStates();
                    break;
                case "Finding the minimum weight spanning tree":
                    SortedSet<Tuple<int, int, int>> solve = SolveFindingTheMinimumWeightSpanningTree();
                    ShowSolveFindingProbabilitiesOfSystemStates(solve);
                    Solution.Text = SaveSolveFindingTheMinimumWeightSpanningTree(solve);
                    break;
            }
        }
    }
}
