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
        private void Form23_Load(object sender, EventArgs e)
        {
            Problem.Text = problemName;
            DataForm.Text = dataFormName;
        }
    }
}
