using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form08 : Form
    {
        Thread thread1, thread2;
        public Form08()
        {
            InitializeComponent();
        }
        public SortedDictionary<int, List<int>> fill_equations(int num_of_equations, SortedDictionary<int, List<int>> equations)
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
        public void show_equations(SortedDictionary<int, List<int>> equations)
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
            thread1 = new Thread(openForm6);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(openForm17);
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
            this.Close();
        }
        private void size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private void generate_Click(object sender, EventArgs e)
        {
            if (size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else
            {
                int num_of_equations = Convert.ToInt32(size.Text);
                SortedDictionary<int, List<int>> equations = new SortedDictionary<int, List<int>>();
                fill_equations(num_of_equations, equations);
                show_equations(equations);
            }
        }
        private void openForm6()
        {
            Application.Run(new Form06());
        }
        private void openForm17()
        {
            Application.Run(new Form17());
        }
    }
}
