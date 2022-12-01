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
        public SortedDictionary<int, List<int>> equations;
        public Form08(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
            //Form.ActiveForm.Visible = false;
        }
        private SortedDictionary<int, List<int>> fill_equations(int num_of_equations, SortedDictionary<int, List<int>> equations)
        {
            Random random = new Random();
            for (int i = 0; i < num_of_equations; i++)
            {
                int[] element = new int[num_of_equations];
                for (int j = 0; j < num_of_equations; j++)
                {
                    element[j] = random.Next(0, 2);
                }
                List<int> equation = new List<int>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        equation.Add(j);
                    }
                }
                equations.Add(i + 1, equation);
            }
            return equations;
        }
        private void show_equations(SortedDictionary<int, List<int>> equations)
        {
            string output = "";
            foreach (KeyValuePair<int, List<int>> pair in equations)
            {
                output += "f_" + pair.Key.ToString() + " = (   ";
                pair.Value.ForEach(delegate (int value)
                {
                    output += "x_" + (value + 1) + "   ";
                });
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
                form17.sendData(equations);
                form17.ShowDialog();
                /*thread2 = new Thread(openForm17);*/
            }
            else
            {
                MessageBox.Show("Please generate data");
                //WHY CLOSES THE APP?
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
                equations = new SortedDictionary<int, List<int>>();
                fill_equations(num_of_equations, equations);
                show_equations(equations);
                generateClicked = true;
            }
        }
    }
}
