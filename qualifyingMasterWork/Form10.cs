using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm1);
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (File.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form22 form22 = new Form22(form23);
                Form21 form21 = new Form21(form23);
                Form20 form20 = new Form20(form21, form22);
                Form11 form11 = new Form11(form20);
                form11.ShowDialog();
            }
            else if (Generate.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form22 form22 = new Form22(form23);
                Form21 form21 = new Form21(form23);
                Form20 form20 = new Form20(form21, form22);
                Form12 form12 = new Form12(form20);
                form12.ShowDialog();
            }
            else if (Manual.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form22 form22 = new Form22(form23);
                Form21 form21 = new Form21(form23);
                Form20 form20 = new Form20(form21, form22);
                Form13 form13 = new Form13(form20);
                form13.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of input");
            }
        }
    }
}
