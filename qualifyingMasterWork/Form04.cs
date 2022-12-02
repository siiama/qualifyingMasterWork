using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form04 : Form
    {
        readonly Form14 form14;
        private bool generateClicked = false;
        private int[,] matrix;
        private string output;
        private int sizeOfMatrix;
        public Form04(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm2);
        }
        private int[,] FillMatrix(int[,] matrix)
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
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else
            {
                sizeOfMatrix = Convert.ToInt32(Size.Text);
                matrix = new int[sizeOfMatrix, sizeOfMatrix];
                FillMatrix(matrix);
                ShowMatix(matrix);
                generateClicked = true;
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true && sizeOfMatrix >= 2)
            {
                Form.ActiveForm.Visible = false;
                form14.SendData(matrix);
                form14.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please generate data");
                //WHY CLOSES THE APP?
            }
        }
        private void ShowMatix(int[,] matrix)
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
        private void Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
