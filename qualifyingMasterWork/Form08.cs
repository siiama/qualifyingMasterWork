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
        private void generate_Click(object sender, EventArgs e)
        {
            if (size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else
            {
                int num_of_equations = Convert.ToInt32(size.Text);
                SortedDictionary<int, int[]> equations = new SortedDictionary<int, int[]>();
                Random random = new Random();
                for (int i = 0; i < num_of_equations; i++)
                {
                    int[] equation = new int[num_of_equations];
                    for (int j = 0; j < num_of_equations; j++)
                    {
                        equation[j] = random.Next(0, 2);
                    }
                    equations.Add(i + 1, equation);
                }
                string output = "";
                foreach (KeyValuePair<int, int[]> pair in equations)
                {
                    output += "f_" + pair.Key.ToString() + " = (   ";
                    for (int i = 0; i < pair.Value.Length; i++)
                    {
                        if (pair.Value[i] == 1)
                        {
                            output += "x_" + (i + 1) + "   ";
                        } 
                    }
                    output += ")\n";
                }
                data.Text = output;
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
