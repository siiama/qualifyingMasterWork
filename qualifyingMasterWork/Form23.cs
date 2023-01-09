﻿using System;
using System.Collections.Generic;
using System.Deployment.Application;
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
        public double SolveDeterminant(int[,] matrixOfEquationCoefficients)
        {
            double determinant = 0;
            int s = 1;
            if (matrixOfEquationCoefficients.GetLength(0) == 1)
            {
                determinant = matrixOfEquationCoefficients[0, 0];
                return determinant;
            }
            else if (matrixOfEquationCoefficients.GetLength(0) == 2)
            {
                determinant = matrixOfEquationCoefficients[0, 0] * matrixOfEquationCoefficients[1, 1] -
                              matrixOfEquationCoefficients[1, 0] * matrixOfEquationCoefficients[0, 1];
                return determinant;
            }
            else if (matrixOfEquationCoefficients.GetLength(0) > 2)
            {
                int[,] newMatrixOfEquationCoefficients = new int[matrixOfEquationCoefficients.GetLength(0) - 1, matrixOfEquationCoefficients.GetLength(1) - 1];
                for (int i=0; i< matrixOfEquationCoefficients.GetLength(0); i++)
                {
                    int subElementJ = 0;
                    int subElementK = 0;
                    for (int j=0; j< matrixOfEquationCoefficients.GetLength(0); j++)
                    {
                        for (int k =0; k< matrixOfEquationCoefficients.GetLength(1); k++)
                        {
                            if (j!=i && k!=0)
                            {
                                newMatrixOfEquationCoefficients[subElementJ, subElementK] = matrixOfEquationCoefficients[j, k];
                                subElementK++;
                                if (subElementK == newMatrixOfEquationCoefficients.GetLength(1))
                                {
                                    subElementJ++;
                                    subElementK = 0;
                                }
                            }
                        }
                    }
                    determinant += s * matrixOfEquationCoefficients[i, 0] * SolveDeterminant(newMatrixOfEquationCoefficients);
                    s *= -1; 
                }
            }
            return determinant;
        }
        public string SolveFindingProbabilitiesOfSystemStates()
        {
            int numOfSystemStates = equations.Count;
            int[,] matrixOfEquationCoefficients = new int[numOfSystemStates, numOfSystemStates];
            for (int i=0; i<matrixOfEquationCoefficients.GetLength(0); i++)
            {
                for (int j=0; j<matrixOfEquationCoefficients.GetLength(1); j++)
                {
                    matrixOfEquationCoefficients[i, j] = 0;
                }
            }
            foreach (KeyValuePair<int, SortedSet<Tuple<int, int>>> equation in equations)
            {
                int function = equation.Key;
                foreach (Tuple<int, int> argument in equation.Value)
                {
                    matrixOfEquationCoefficients[function, argument.Item1] = argument.Item2;
                }
            }
            double delta = SolveDeterminant(matrixOfEquationCoefficients);
            int[,] matrixOfCoefficientsX = new int[numOfSystemStates, numOfSystemStates];
            double[] delta_x = new double[numOfSystemStates];
            if (vertexes.Count == 0)
            {
                MessageBox.Show("You have not input vertexes weights!");
            }
            for (int i=0; i<delta_x.GetLength(0); i++)
            {
                for (int j=0; j< matrixOfCoefficientsX.GetLength(0); j++)
                {
                    for (int k=0; k<matrixOfCoefficientsX.GetLength(1); k++)
                    {
                        matrixOfCoefficientsX[j,k] = matrixOfEquationCoefficients[j,k];
                    }
                }
                foreach (Tuple<int, int> vertex in vertexes)
                {
                    matrixOfCoefficientsX[vertex.Item1, i] = vertex.Item2;
                }
                delta_x[i] = SolveDeterminant(matrixOfCoefficientsX);
            }
            bool determined = false;
            bool compatible = true;
            if (delta != 0)
            {
                determined = true;
            }
            for (int i = 0; i < numOfSystemStates; i++)
            {
                if (delta_x[i] != 0)
                {
                    compatible = false;
                }
            }
            if (determined)
            {
                double[] x = new double[numOfSystemStates];
                for (int i=0; i<numOfSystemStates; i++)
                {
                    x[i] = delta_x[i] / delta;
                    result += "x_" + i + " = " + String.Format("{0:0.00}", x[i]) + ", ";
                }
                result = result.Remove(result.Length - 2);
                result += ".";
            }
            else if (compatible)
            {
                result += "infinitely many solutions. One of them: ";
                for (int i = 0; i < numOfSystemStates; i++)
                {
                    result += "x_" + i + " = 0, ";
                }
            }
            else
            {
                result += "no solution";
            }
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
