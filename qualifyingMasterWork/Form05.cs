using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form05 : Form
    {
        readonly Form14 form14;
        private int[,] matrix;
        private bool okClicked = false;
        private int sizeOfMatrix;
        public Form05(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02();
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
                form14.SendData(matrix);
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
    }
}
