using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form08 : Form
    {
        readonly Form17 form17;
        private SortedDictionary<int, HashSet<int>> equations;
        private bool generateClicked = false;
        private int numOfEquations;
        public Form08(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06();
            form06.ShowDialog();
        }
        private SortedDictionary<int, HashSet<int>> FillEquations(int numOfEquations, SortedDictionary<int, HashSet<int>> equations)
        {
            Random random = new Random();
            for (int i = 0; i < numOfEquations; i++)
            {
                int[] element = new int[numOfEquations];
                for (int j = 0; j < numOfEquations; j++)
                {
                    element[j] = random.Next(0, 2);
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
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else
            {
                numOfEquations = Convert.ToInt32(Size.Text);
                equations = new SortedDictionary<int, HashSet<int>>();
                FillEquations(numOfEquations, equations);
                ShowEquations(equations);
                generateClicked = true;
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true && numOfEquations >= 2)
            {
                Form.ActiveForm.Visible = false;
                form17.SendData(equations);
                form17.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        private void ShowEquations(SortedDictionary<int, HashSet<int>> equations)
        {
            string output = "";
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                output += "f_" + (equation.Key+1).ToString() + " = (   ";
                foreach (int value in equation.Value)
                {
                    output += "x_" + (value + 1) + "   ";
                }
                output += ")\n";
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
