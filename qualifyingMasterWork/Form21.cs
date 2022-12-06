using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form21 : Form
    {
        readonly Form23 form23;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private int[,] matrix;
        private string output;
        private int sizeOfMatrix;
        private string result;
        public Form21(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form23 form23 = new Form23();
            Form22 form22 = new Form22(form23);
            Form21 form21 = new Form21(form23);
            Form20 form20 = new Form20(form21, form22);
            form20.SendData(commutativeDiagram);
            form20.ShowDialog();
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            foreach (Tuple<int, int> edge in commutativeDiagram)
            {
                int i = edge.Item1;
                int j = edge.Item2;
                matrix[i, j] = 1;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            form23.ShowDialog();
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
                    result += matrix[i, j].ToString() + " ";
                }
                result = result.Remove(result.Length - 1);
                result += "\n";
            }
            result = result.Remove(result.Length - 1);
        }
        public void SendData(HashSet<Tuple<int, int>> data)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            commutativeDiagram = data;
        }
        private void ShowMatrix(int[,] matrix)
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
            Data.Text = output;
        }
    }
}
