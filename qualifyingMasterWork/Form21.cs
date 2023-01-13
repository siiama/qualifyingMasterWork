using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form21 : Form
    {
        readonly Form21 form21;
        readonly Form22 form22;
        readonly Form23 form23;
        private string dataFormName;
        private SortedSet<Tuple<int, int, int>> commutativeDiagram;
        private int[,] matrix;
        private string output;
        private string problemName;
        private int sizeOfMatrix;
        private string result;
        private SortedSet<Tuple<int, int>> vertexes;
        public Form21(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            for (int i=0; i<matrix.GetLength(0); i++)
            {
                for (int j=0; j<matrix.GetLength(1); j++)
                {
                    matrix[i, j] = -1;
                }
            }
            foreach (Tuple<int, int, int> edge in commutativeDiagram)
            {
                int i = edge.Item1;
                int j = edge.Item2;
                matrix[i, j] = edge.Item3;
            }
            return matrix;
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
                    form23.SendMatrixData(matrix);
                    form23.SendProblem(problemName);
                    form23.ShowDialog();
                    break;
            }
        }
        private void Form21_Load(object sender, EventArgs e)
        {
            sizeOfMatrix = commutativeDiagram.Max(v => v.Item1) + 1;
            matrix = new int[sizeOfMatrix, sizeOfMatrix];
            FillMatrix(matrix);
            ShowMatrix(matrix);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveMatrix();
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void SaveMatrix()
        {
            result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j].ToString() + ", ";
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
        private void ShowMatrix(int[,] matrix)
        {
            output = "";
            if (matrix.GetLength(0) > 100)
            {
                output += "data is too big. Please save it to watch.";
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        output += matrix[i, j].ToString() + "   ";
                    }
                    output += "\n";
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
