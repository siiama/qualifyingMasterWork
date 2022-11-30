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
    public partial class Form04 : Form
    {
        Form14 form14;
        public int size_of_matrix;
        public int[,] matrix;
        public Form04(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
            //Form.ActiveForm.Visible = false;
        }
        private int[,] fillMatrix(int[,] matrix)
        {
            Random random = new Random();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 2);
                }
            }
            return matrix;
        }
        private void showMatix(int[,] matrix)
        {
            string output = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output += matrix[i, j].ToString() + "   ";
                }
                output += "\n";
            }
            data.Text = output;
        }
        private void back_Click(object sender, EventArgs e)
        {
            /*thread1 = new Thread(openForm2);*/
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (generateClicked == true && size_of_matrix >=2)
            {
                form14.sendData(matrix);
                form14.ShowDialog();
                /*thread2 = new Thread(openForm14);*/
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
                size_of_matrix = Convert.ToInt32(size.Text);
                matrix = new int[size_of_matrix, size_of_matrix];
                fillMatrix(matrix);
                showMatix(matrix);
                generateClicked = true;
            }
        }
    }
}
