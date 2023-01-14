using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form03 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form14 form14;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private string dataFormName;
        private bool chooseFileClicked = false;
        private string[] elementInRow;
        private string fileData;
        private string fileName;
        private int[,] matrix;
        private string problemName;
        private string[] row;
        private SortedSet<Tuple<int, int>> vertexes;
        private Tuple<int, int> vertexFromFile;
        private string[] vertexesFromFile;
        private string[] weightsOfVertexes;
        private int sizeOfMatrix;
        public Form03(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02(form03, form04, form05);
            form02.SendDataForm(dataFormName);
            form02.SendProblem(problemName);
            form02.ShowDialog();
        }
        private bool CheckDataFromFile()
        {
            var charsToRemove = new string[] { " ", "." };
            string matrixNumbers = fileData.Substring(0, fileData.IndexOf('.'));
            foreach (var c in charsToRemove)
            {
                matrixNumbers = matrixNumbers.Replace(c, string.Empty);
            }
            matrixNumbers = matrixNumbers.Replace(";", ",");
            matrixNumbers = matrixNumbers.Replace(Environment.NewLine, string.Empty);
            sizeOfMatrix = fileData.Substring(0, fileData.IndexOf('.')).Split(';').Length;
            bool hasNegativeWeight = false;
            row = new string[sizeOfMatrix];
            row = fileData.Substring(0, fileData.IndexOf('.')).Split(';');
            for (int i = 0; i < row.Length; i++)
            {
                elementInRow = new string[sizeOfMatrix];
                foreach (var c in charsToRemove)
                {
                    row[i] = row[i].Replace(c, string.Empty);
                }
                row[i] = row[i].Replace(Environment.NewLine, string.Empty);
                elementInRow = row[i].Split(',');
                for (int j = 0; j < elementInRow.Length; j++)
                {
                    if (Convert.ToInt32(elementInRow[j]) < -1)
                    {
                        hasNegativeWeight = true;
                    }
                }
            }
            if (matrixNumbers.Split(',').Length != sizeOfMatrix * sizeOfMatrix)
            {
                MessageBox.Show("Your matrix is not square!");
                return false;
            }
            else if (hasNegativeWeight)
            {
                MessageBox.Show("Edges can not have\nnegative weights!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            file.Text = System.IO.Path.GetFileName(fileName);
            chooseFileClicked = true;
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            row = new string[matrix.GetLength(0)];
            row = fileData.Substring(0, fileData.IndexOf('.')).Split(';');
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
            vertexesFromFile = fileData.Substring(fileData.IndexOf('.')).Split(';');
            if (vertexesFromFile.Length == sizeOfMatrix)
            {
                bool hasNegativeWeight = false;
                for (int i = 0; i < vertexesFromFile.Length; i++)
                {
                    string vertexesWeigths = vertexesFromFile[i];
                    var charsToRemove = new string[] { " ", ".", "_" };
                    foreach (var c in charsToRemove)
                    {
                        vertexesWeigths = vertexesWeigths.Replace(c, string.Empty);
                    }
                    vertexesWeigths = Regex.Replace(vertexesWeigths, "[A-Za-z]", string.Empty);
                    vertexesWeigths = vertexesWeigths.Replace(Environment.NewLine, string.Empty);
                    weightsOfVertexes = vertexesWeigths.Split(',');
                    int weight = Convert.ToInt32(weightsOfVertexes[1]);
                    if (Convert.ToInt32(weightsOfVertexes[1]) < 0)
                    {
                        weight = 0;
                        hasNegativeWeight = true;
                    }
                    vertexFromFile = new Tuple<int, int>(Convert.ToInt32(weightsOfVertexes[0]) - 1, weight);
                    vertexes.Add(vertexFromFile);
                }
                if (hasNegativeWeight)
                {
                    MessageBox.Show("Some vertexes weights were negative\nand were replaced with 0");
                }
            }
            else
            {
                vertexes.Clear();
                for (int i = 0; i < sizeOfMatrix; i++)
                {
                    vertexes.Add(new Tuple<int, int>(i, 0));
                }
                MessageBox.Show("You did not provide vertexes weights\nso they all will be 0");
            }
            return vertexes;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    if (CheckDataFromFile())
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
                else
                {
                    MessageBox.Show("Empty file");
                }
            }
            else
            {
                MessageBox.Show("Please choose file");
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
