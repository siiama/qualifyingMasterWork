using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form18 : Form
    {
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private string dataFormName;
        private SortedDictionary<int, SortedSet<Tuple<int, int>>> equations;
        private int[,] matrix;
        private string output;
        private string problemName;
        private string result;
        private int sizeOfMatrix;
        public Form18(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = -1;
                }
            }
            foreach (KeyValuePair<int, SortedSet<Tuple<int, int>>> equation in equations)
            {
                int function = equation.Key;
                foreach (Tuple<int, int> argument in equation.Value)
                {
                    matrix[function, argument.Item1] = argument.Item2;
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
                    form23.SendSystemOfEquationsData(equations);
                    form23.SendProblem(problemName);
                    form23.ShowDialog();
                    break;
            }
        }
        private void Form18_Load(object sender, EventArgs e)
        {
            sizeOfMatrix = equations.Count();
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
        }
        public void SendData(SortedDictionary<int, SortedSet<Tuple<int, int>>> data)
        {
            equations = new SortedDictionary<int, SortedSet<Tuple<int, int>>>();
            equations = data;
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
