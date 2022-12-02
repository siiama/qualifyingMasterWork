using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (Matrix.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form02 form02 = new Form02();
                form02.ShowDialog();
            }
            else if (SystemOfEquations.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form06 form06 = new Form06();
                form06.ShowDialog();
            }
            else if (CommutativeDiagram.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form10 form10 = new Form10();
                form10.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
