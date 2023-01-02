using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form13 : Form
    {
        readonly Form11 form11;
        readonly Form12 form12;
        readonly Form13 form13;
        readonly Form20 form20;
        readonly Form21 form21;
        readonly Form22 form22;
        readonly Form23 form23;
        private Tuple<int, int> edgeFromTextbox;
        private string[] edgesFromTextbox;
        private string dataFormName;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private int numOfVertexesInEachPart;
        private string problemName;
        private string[] vertexInEdges;
        public Form13(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form10 form10 = new Form10(form11, form12, form13);
            form10.SendDataForm(dataFormName);
            form10.SendProblem(problemName);
            form10.ShowDialog();
        }
        private bool CheckDataFromManualInput()
        {
            string[] edges = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';');
            int maxNumOfElementsInLeftPart = 0;
            int maxNumOfElementsInRightPart = 0;
            for (int i = 0; i < edges.Length; i++)
            {
                var charsToRemove = new string[] { " ", ".", "_" };
                string edgesElements = edges[i];
                foreach (var c in charsToRemove)
                {
                    edgesElements = edgesElements.Replace(c, string.Empty);
                }
                edgesElements = Regex.Replace(edgesElements, "[A-Za-z]", string.Empty);
                edgesElements = edgesElements.Replace(Environment.NewLine, string.Empty);
                string[] edge = edgesElements.Split(',');
                if ((Convert.ToInt32(edge[0]) - 1) > maxNumOfElementsInLeftPart)
                {
                    maxNumOfElementsInLeftPart = Convert.ToInt32(edge[0]) - 1;
                }
                if ((Convert.ToInt32(edge[1]) - 1) > maxNumOfElementsInRightPart)
                {
                    maxNumOfElementsInRightPart = Convert.ToInt32(edge[1]) - 1;
                }
            }
            if (maxNumOfElementsInLeftPart < maxNumOfElementsInRightPart)
            {
                MessageBox.Show("Number of vertexes in left part can not be less\nthen number of vertexes in rigth part!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8)
                && e.KeyChar != Convert.ToChar(13) && e.KeyChar != Convert.ToChar(32) && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(45) && e.KeyChar != Convert.ToChar(46) && e.KeyChar != Convert.ToChar(59))
            {
                e.Handled = true;
            }
        }
        private HashSet<Tuple<int, int>> FillCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            edgesFromTextbox = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';');
            for (int i = 0; i < edgesFromTextbox.Length; i++)
            {
                string edgesElements = edgesFromTextbox[i];
                var charsToRemove = new string[] { " ", ".", "_" };
                foreach (var c in charsToRemove)
                {
                    edgesElements = edgesElements.Replace(c, string.Empty);
                }
                edgesElements = Regex.Replace(edgesElements, "[A-Za-z]", string.Empty);
                edgesElements = edgesElements.Replace(Environment.NewLine, string.Empty);
                vertexInEdges = edgesElements.Split(',');
                edgeFromTextbox = new Tuple<int, int> (Convert.ToInt32(vertexInEdges[0]) - 1, Convert.ToInt32(vertexInEdges[1]) - 1);
                commutativeDiagram.Add(edgeFromTextbox);
            }
            return commutativeDiagram;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                commutativeDiagram = new HashSet<Tuple<int, int>>();
                FillCommutativeDiagram(commutativeDiagram);
                switch (problemName)
                {
                    case "Finding the shortest path":
                        Form.ActiveForm.Visible = false;
                        Form21 form21_ = new Form21(form23);
                        form21_.SendData(commutativeDiagram);
                        form21_.SendDataForm(dataFormName);
                        form21_.SendProblem(problemName);
                        form21_.ShowDialog();
                        break;
                    case "Finding probabilities of system states":
                        Form.ActiveForm.Visible = false;
                        Form22 form22_ = new Form22(form23);
                        form22_.SendData(commutativeDiagram);
                        form22_.SendDataForm(dataFormName);
                        form22_.SendProblem(problemName);
                        form22_.ShowDialog();
                        break;
                    case "Finding the minimum weight spanning tree":
                        Form.ActiveForm.Visible = false;
                        Form23 form23_ = new Form23();
                        form23_.SendDataForm(dataFormName);
                        form23_.SendCommutativeDiagramData(commutativeDiagram);
                        form23_.SendProblem(problemName);
                        form23_.ShowDialog();
                        break;
                    case "skip":
                        Form.ActiveForm.Visible = false;
                        Form20 form20 = new Form20(form21, form22);
                        form20.SendData(commutativeDiagram);
                        form20.SendProblem(problemName);
                        form20.ShowDialog();
                        break;
                }
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
    }
}
