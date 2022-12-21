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
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private int[,] matrix;
        private string output;
        private string problemName;
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
            switch (problemName)
            {
                case "skip":
                    Form.ActiveForm.Visible = false;
                    break;
                default:
                    Form.ActiveForm.Visible = false;
                    Form23 form23 = new Form23();
                    form23.SendDataForm(dataFormName);
                    form23.SendCommutativeDiagramData(commutativeDiagram);
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
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
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
