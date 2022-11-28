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
                int size_of_matrix = Convert.ToInt32(size.Text);
                int[,] matrix = new int[size_of_matrix, size_of_matrix];
                Random random = new Random();
                for (int i = 0; i < size_of_matrix; i++)
                {
                    for (int j = 0; j < size_of_matrix; j++)
                    {
                        matrix[i, j] = random.Next(0, 2);
                    }
                }
                string output = "";
                for (int i = 0; i < size_of_matrix; i++)
                {
                    output += "f_" + (i + 1) + " = (   ";
                    for (int j = 0; j < size_of_matrix; j++)
                    {
                        if (matrix[i, j] == 1)
                        output += "x_" + (j+1) + "   ";
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
