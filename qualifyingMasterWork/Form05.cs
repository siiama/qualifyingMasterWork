using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form05 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form14 form14;
        readonly Form15 form15;
        readonly Form16 form16;
        private int[,] matrix;
        private bool okClicked = false;
        private string problemName;
        private int sizeOfMatrix;
        public Form05(Form14 form14)
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
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //FILL MATRIX
                }
            }
            return matrix;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (okClicked == true)// && INPUT IS NOT NULL
            {
                /*Form.ActiveForm.Visible = false;
                Form14 form14 = new Form14(form15, form16);
                form14.SendData(matrix);
                form14.SendProblem(problemName);
                form14.ShowDialog();*/
            }
            else
            {
                MessageBox.Show("Please input data");
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(Size.Text) > 1)
            {
                if (Convert.ToInt32(Size.Text) > 10)
                    MessageBox.Show("Are you patient enough to input data manually?");
                sizeOfMatrix = Convert.ToInt32(Size.Text);
                matrix = new int[sizeOfMatrix, sizeOfMatrix];
                //DO BUTTONS TO INPUT MANUALLY

                FillMatrix(matrix);
                okClicked = true;
            }
            else
            {
                MessageBox.Show("Size should be > 1");
            }
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
