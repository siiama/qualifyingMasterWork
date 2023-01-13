using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form04 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form14 form14;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private string dataFormName;
        private bool generateClicked = false;
        private int[,] matrix;
        private string result;
        private string output;
        private string problemName;
        private int sizeOfMatrix;
        private SortedSet<Tuple<int, int>> vertexes;
        public Form04(Form14 form14)
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
        private int[,] FillMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-1, 1);
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, j] = random.Next(0, matrix.GetLength(0));
                    }
                }
            }
            return matrix;
        }
        private SortedSet<Tuple<int, int>> FillMatrixVertexesWeights(SortedSet<Tuple<int, int>> vertexes)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Tuple<int, int> vertex = new Tuple<int, int>(i, random.Next(0, matrix.GetLength(0)));
                vertexes.Add(vertex);
            }
            return vertexes;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(Size.Text) > 1)
            {
                sizeOfMatrix = Convert.ToInt32(Size.Text);
                matrix = new int[sizeOfMatrix, sizeOfMatrix];
                vertexes = new SortedSet<Tuple<int, int>>();
                FillMatrix(matrix);
                FillMatrixVertexesWeights(vertexes);
                ShowMatix(matrix);
                generateClicked = true;
            }
            else
            {
                MessageBox.Show("Size should be > 1");
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true)
            {
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
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (generateClicked == true)
            {
                if (SaveFile.ShowDialog() == DialogResult.Cancel)
                    return;
                SaveMatrix();
                string filename = SaveFile.FileName;
                System.IO.File.WriteAllText(filename, result);
            }
            else
            {
                MessageBox.Show("Please generate data");
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
        private void ShowMatix(int[,] matrix)
        {
            output = "";
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
                output += "v_" + (vertex.Item1 + 1).ToString() + " - w_" + (vertex.Item2).ToString() + "\n";
            }
            Data.Text = output;
        }
        private void Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
