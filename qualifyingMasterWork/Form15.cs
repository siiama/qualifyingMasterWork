using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form15 : Form
    {
        readonly Form23 form23;
        private SortedDictionary<int, HashSet<int>> equations;
        private int[,] matrix;
        private int numOfEquations;
        private string output;
        private string result;
        public Form15(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form23 form23 = new Form23();
            Form16 form16 = new Form16(form23);
            Form15 form15 = new Form15(form23);
            Form14 form14 = new Form14(form15, form16);
            form14.SendData(matrix);
            form14.ShowDialog();
        }
        private SortedDictionary<int, HashSet<int>> FillEquations(int numOfEquations, SortedDictionary<int, HashSet<int>> equations)
        {
            for (int i = 0; i < numOfEquations; i++)
            {
                int[] element = new int[numOfEquations];
                for (int j = 0; j < numOfEquations; j++)
                {
                    element[j] = matrix[i, j];
                }
                HashSet<int> equation = new HashSet<int>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        equation.Add(j);
                    }
                }
                equations.Add(i, equation);
            }
            return equations;
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            form23.ShowDialog();
        }
        private void Form15_Load(object sender, EventArgs e)
        {
            numOfEquations = matrix.GetLength(0);
            equations = new SortedDictionary<int, HashSet<int>>();
            FillEquations(numOfEquations, equations);
            ShowEquations(equations);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveEquations(equations);
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void SaveEquations(SortedDictionary<int, HashSet<int>> equations)
        {
            result = "";
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                result += "f_" + equation.Key.ToString() + ": ";
                foreach (int value in equation.Value)
                {
                    result += "x_" + (value + 1) + " ";
                }
                result += "\n";
            }
        }
        public void SendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
        }
        private void ShowEquations(SortedDictionary<int, HashSet<int>> equations)
        {
            output = "";
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                output += "f_" + (equation.Key + 1).ToString() + " = (   ";
                foreach (int value in equation.Value)
                {
                    output += "x_" + (value + 1) + "   ";
                }
                output += ")\n";
            }
            Data.Text = output;
        }
    }
}
