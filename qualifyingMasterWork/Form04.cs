using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form04 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form14 form14;
        readonly Form15 form15;
        readonly Form16 form16;
        private bool generateClicked = false;
        private int[,] matrix;
        private string output;
        private string problemName;
        private int sizeOfMatrix;
        public Form04(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02(form03, form04, form05);
            form02.ShowDialog();
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
            else if (Convert.ToInt32(Size.Text) > 1)
            {
                sizeOfMatrix = Convert.ToInt32(Size.Text);
                matrix = new int[sizeOfMatrix, sizeOfMatrix];
                FillMatrix(matrix);
                ShowMatix(matrix);
                generateClicked = true;
            }
            else
            {
                MessageBox.Show("Size should be > 1");
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true)
            {
                Form.ActiveForm.Visible = false;
                Form14 form14 = new Form14(form15, form16);
                form14.SendData(matrix);
                form14.SendProblem(problemName);
                form14.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
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
