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
    public partial class Form05 : Form
    {
        Form14 form14;
        public int size_of_matrix;
        public int[,] matrix;
        public Form05(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
            //Form.ActiveForm.Visible = false;
        }
        private int[,] fillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //matrix[i, j] = random.Next(0, 2);
                }
            }
            return matrix;
        }
        private void back_Click(object sender, EventArgs e)
        {
            /*thread1 = new Thread(openForm2);*/
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (okClicked == true)// && INPUT IS NOT NULL
            {
                form14.sendData(matrix);
                form14.ShowDialog();
                /*thread2 = new Thread(openForm14);*/
            }
            else
            {
                MessageBox.Show("Please input data");
            }
        }
        bool okClicked = false;
        private void ok_Click(object sender, EventArgs e)
        {
            if (size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(size.Text) > 10)
            {
                MessageBox.Show("Are you patient enough to input data manually?");
                //LET USER INPUT DATA ANYWAY
            }
            else
            {
                size_of_matrix = Convert.ToInt32(size.Text);
                matrix = new int[size_of_matrix, size_of_matrix];
                //DO BUTTONS TO INPUT MANUALLY
                fillMatrix(matrix);
                okClicked = true;
            }
        }
    }
}
