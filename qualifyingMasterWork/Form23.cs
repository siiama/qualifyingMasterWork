using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form23 : Form
    {
        private string dataFormName;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private int[,] matrix;
        private string problemName;
        private SortedDictionary<int, HashSet<int>> equations;
        public string result;
        public Form23()
        {
            InitializeComponent();
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
        }
        public void SendCommutativeDiagramData(HashSet<Tuple<int, int>> commutativeDiagramData)
        {
            commutativeDiagram = commutativeDiagramData;
        }
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendMatrixData(int[,] matrixData)
        {
            matrix = matrixData;
        }
        public void SendSystemOfEquationsData(SortedDictionary<int, HashSet<int>> equationsData)
        {
            equations = equationsData;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
        public string SolveFindingProbabilitiesOfSystemStates()
        {
            //system of equations
            //value of every vertex
            return result;
        }
        public string SolveFindingTheMinimumWeightSpanningTree()
        {
            //commutative diagram
            //minimum spanning tree
            return result;
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
                    Solution.Text = SolveFindingTheMinimumWeightSpanningTree();
                    break;
            }
        }
    }
}
