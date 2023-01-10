using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form05 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form14 form14;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private string dataFormName;
        private string[] elementInRow;
        private int[,] matrix;
        private string problemName;
        private string result;
        private string[] row;
        private int sizeOfMatrix;
        private SortedSet<Tuple<int, int>> vertexes;
        private Tuple<int, int> vertexFromTextbox;
        private string[] vertexesFromTextbox;
        private string[] weightsOfVertexes;
        public Form05(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02(form03, form04, form05);
            form02.SendDataForm(dataFormName);
            form02.SendProblem(problemName);
            form02.ShowDialog();
        }
        private bool CheckDataFromManualInput()
        {
            var charsToRemove = new string[] { " ", "." };
            string matrixNumbers = Data.Text.Substring(0, Data.Text.IndexOf('.'));
            foreach (var c in charsToRemove)
            {
                matrixNumbers = matrixNumbers.Replace(c, string.Empty);
            }
            matrixNumbers = matrixNumbers.Replace(";", ",");
            matrixNumbers = matrixNumbers.Replace(Environment.NewLine, string.Empty);
            sizeOfMatrix = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';').Length;
            if (matrixNumbers.Split(',').Length != sizeOfMatrix * sizeOfMatrix)
            {
                MessageBox.Show("Your matrix is not square!");
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
                && e.KeyChar != Convert.ToChar(45) && e.KeyChar != Convert.ToChar(46) && e.KeyChar != Convert.ToChar(58)
                && e.KeyChar != Convert.ToChar(59))
            {
                e.Handled = true;
            }
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            row = new string[matrix.GetLength(0)];
            row = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';');
            for (int i = 0; i < row.Length; i++)
            {
                elementInRow = new string[matrix.GetLength(1)];
                var charsToRemove = new string[] { " ", "." };
                foreach (var c in charsToRemove)
                {
                    row[i] = row[i].Replace(c, string.Empty);
                }
                row[i] = row[i].Replace(Environment.NewLine, string.Empty);
                elementInRow = row[i].Split(',');
                for (int j = 0; j < elementInRow.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(elementInRow[j]);
                }
            }
            return matrix;
        }
        private SortedSet<Tuple<int, int>> FillMatrixVertexesWeights(SortedSet<Tuple<int, int>> vertexes)
        {
            vertexesFromTextbox = Data.Text.Substring(Data.Text.IndexOf('.')).Split(';');
            if (vertexesFromTextbox.Length == sizeOfMatrix)
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
                for (int i = 0; i < sizeOfMatrix; i++)
                {
                    vertexes.Add(new Tuple<int, int>(i, 0));
                }
            }
            return vertexes;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                matrix = new int[sizeOfMatrix, sizeOfMatrix];
                FillMatrix(matrix);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillMatrixVertexesWeights(vertexes);
                switch (problemName)
                {
                    case "Finding the shortest path":
                        Form.ActiveForm.Visible = false;
                        Form23 form23_ = new Form23();
                        form23_.SendDataForm(dataFormName);
                        form23_.SendDataVertexesWeights(vertexes);
                        form23_.SendMatrixData(matrix);
                        form23_.SendProblem(problemName);
                        form23_.ShowDialog();
                        break;
                    case "Finding probabilities of system states":
                        Form.ActiveForm.Visible = false;
                        Form15 form15_ = new Form15(form23);
                        form15_.SendData(matrix);
                        form15_.SendDataForm(dataFormName);
                        form15_.SendDataVertexesWeights(vertexes);
                        form15_.SendProblem(problemName);
                        form15_.ShowDialog();
                        break;
                    case "Finding the minimum weight spanning tree":
                        Form.ActiveForm.Visible = false;
                        Form16 form16_ = new Form16(form23);
                        form16_.SendData(matrix);
                        form16_.SendDataForm(dataFormName);
                        form16_.SendDataVertexesWeights(vertexes);
                        form16_.SendProblem(problemName);
                        form16_.ShowDialog();
                        break;
                    case "skip":
                        Form.ActiveForm.Visible = false;
                        Form14 form14 = new Form14(form15, form16);
                        form14.SendData(matrix);
                        form14.SendDataVertexesWeights(vertexes);
                        form14.SendProblem(problemName);
                        form14.ShowDialog();
                        break;
                }
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                matrix = new int[sizeOfMatrix, sizeOfMatrix];
                FillMatrix(matrix);
                vertexes = new SortedSet<Tuple<int, int>>();
                FillMatrixVertexesWeights(vertexes);
                if (SaveFile.ShowDialog() == DialogResult.Cancel)
                    return;
                SaveMatrix();
                string filename = SaveFile.FileName;
                System.IO.File.WriteAllText(filename, result);
            }
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
