using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form14 : Form
    {
        readonly Form15 form15;
        readonly Form16 form16;
        private int[,] matrix;
        public Form14(Form15 form15, Form16 form16)
        {
            InitializeComponent();
            this.form15 = form15;
            this.form16 = form16;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02();
            form02.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (SystemOfEquations.Checked)
            {
                Form.ActiveForm.Visible = false;
                form15.SendData(matrix);
                form15.ShowDialog();
            }
            else if (CommutativeDiagram.Checked)
            {
                Form.ActiveForm.Visible = false;
                form16.SendData(matrix);
                form16.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        public void SendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
        }
    }
}
