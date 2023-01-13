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
        private Tuple<int, int, int> edgeFromTextbox;
        private string[] edgesFromTextbox;
        private string dataFormName;
        private SortedSet<Tuple<int, int, int>> commutativeDiagram;
        private int numOfVertexesInEachPart;
        private string problemName;
        private string result;
        private string[] vertexInEdges;
        private SortedSet<Tuple<int, int>> vertexes;
        private Tuple<int, int> vertexFromTextbox;
        private string[] vertexesFromTextbox;
        private string[] weightsOfVertexes;
        public Form13(Form20 form20)
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
        private bool CheckDataFromManualInput()
        {
            string[] edges = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';');
            int maxNumOfElementsInLeftPart = 0;
            int maxNumOfElementsInRightPart = 0;
            bool wrongEdge = false;
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
                if (edgesElements.Length > 3)
                {
                    wrongEdge = true;
                }
                string[] edge = edgesElements.Split(',');
                if (Convert.ToInt32(edge[0]) > maxNumOfElementsInLeftPart)
                {
                    maxNumOfElementsInLeftPart = Convert.ToInt32(edge[0]);
                }
                if (Convert.ToInt32(edge[1]) > maxNumOfElementsInRightPart)
                {
                    maxNumOfElementsInRightPart = Convert.ToInt32(edge[1]);
                }
            }
            if (maxNumOfElementsInLeftPart < maxNumOfElementsInRightPart)
            {
                MessageBox.Show("Number of vertexes in left part can not be less\nthen number of vertexes in rigth part!");
                return false;
            }
            else if (wrongEdge)
            {
                MessageBox.Show("Wrong number of edges elements!");
                return false;
            }
            else
            {
                numOfVertexesInEachPart = maxNumOfElementsInLeftPart;
                return true;
            }
        }
        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8)
                && e.KeyChar != Convert.ToChar(13) && e.KeyChar != Convert.ToChar(32) && e.KeyChar != Convert.ToChar(44)
                && e.KeyChar != Convert.ToChar(46) && e.KeyChar != Convert.ToChar(59))
            {
                e.Handled = true;
            }
        }
        private SortedSet<Tuple<int, int, int>> FillCommutativeDiagram(SortedSet<Tuple<int, int, int>> commutativeDiagram)
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
                edgeFromTextbox = new Tuple<int, int, int> (Convert.ToInt32(vertexInEdges[0]) - 1, Convert.ToInt32(vertexInEdges[1]) - 1, Convert.ToInt32(vertexInEdges[2]));
                commutativeDiagram.Add(edgeFromTextbox);
            }
            return commutativeDiagram;
        }
        private SortedSet<Tuple<int, int>> FillCommutativeDiagramVertexesWeights(SortedSet<Tuple<int, int>> vertexes)
        {
            vertexesFromTextbox = Data.Text.Substring(Data.Text.IndexOf('.')).Split(';');
            if (vertexesFromTextbox.Length == numOfVertexesInEachPart)
            {
                for (int i = 0; i < vertexesFromTextbox.Length; i++)
                {
                    string vertexesWeigths = vertexesFromTextbox[i];
                    var charsToRemove = new string[] { " ", ".", "_" };
                    foreach (var c in charsToRemove)
                    {
                        vertexesWeigths = vertexesWeigths.Replace(c, string.Empty);
                    }
                    vertexesWeigths = Regex.Replace(vertexesWeigths, "[A-Za-z]", string.Empty);
                    vertexesWeigths = vertexesWeigths.Replace(Environment.NewLine, string.Empty);
                    weightsOfVertexes = vertexesWeigths.Split(',');
                    vertexFromTextbox = new Tuple<int, int>(Convert.ToInt32(weightsOfVertexes[0]) - 1, Convert.ToInt32(weightsOfVertexes[1]));
                    vertexes.Add(vertexFromTextbox);
                }
            }
            else
            {
                vertexes.Clear();
                for (int i = 0; i < numOfVertexesInEachPart; i++)
                {
                    vertexes.Add(new Tuple<int, int>(i, 0));
                }
                MessageBox.Show("You did not provide vertexes weights\nso they all will be 0");
            }
            return vertexes;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                commutativeDiagram = new SortedSet<Tuple<int, int, int>>();
                FillCommutativeDiagram(commutativeDiagram);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillCommutativeDiagramVertexesWeights(vertexes);
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
            if (CheckDataFromManualInput())
            {
                commutativeDiagram = new SortedSet<Tuple<int, int, int>>();
                FillCommutativeDiagram(commutativeDiagram);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillCommutativeDiagramVertexesWeights(vertexes);
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
    }
}
