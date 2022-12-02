using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form08 : Form
    {
        Form17 form17;
        public int num_of_equations;
        public SortedDictionary<int, HashSet<int>> equations;
        public Form08(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
        }
        private SortedDictionary<int, HashSet<int>> fill_equations(int num_of_equations, SortedDictionary<int, HashSet<int>> equations)
        {
            Random random = new Random();
            for (int i = 0; i < num_of_equations; i++)
            {
                int[] element = new int[num_of_equations];
                for (int j = 0; j < num_of_equations; j++)
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
        private void show_equations(SortedDictionary<int, HashSet<int>> equations)
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
            data.Text = output;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm6);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true && num_of_equations >= 2)
            {
                Form.ActiveForm.Visible = false;
                form17.sendData(equations);
                form17.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        private void size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private bool generateClicked = false;
        private void generate_Click(object sender, EventArgs e)
        {
            if (size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else
            {
                num_of_equations = Convert.ToInt32(size.Text);
                equations = new SortedDictionary<int, HashSet<int>>();
                fill_equations(num_of_equations, equations);
                show_equations(equations);
                generateClicked = true;
            }
        }
    }
}
