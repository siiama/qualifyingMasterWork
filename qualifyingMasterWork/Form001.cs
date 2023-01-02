using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form001 : Form
    {
        readonly Form01 form01;
        readonly Form02 form02;
        readonly Form06 form06;
        readonly Form10 form10;
        public Form001(Form01 form01)
        {
            InitializeComponent();
            this.form01 = form01;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            Form01 form01 = new Form01(form02, form06, form10);
            if (Problem1.Checked)
            {
                Form.ActiveForm.Visible = false;
                form01.SendProblem(Problem1.Text);
                form01.ShowDialog();
            }
            else if (Problem2.Checked)
            {
                Form.ActiveForm.Visible = false;
                form01.SendProblem(Problem2.Text);
                form01.ShowDialog();
            }
            else if (Problem3.Checked)
            {
                Form.ActiveForm.Visible = false;
                form01.SendProblem(Problem3.Text);
                form01.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose problem");
            }
        }
        private void Skip_Click(object sender, EventArgs e)
        {
            Form01 form01 = new Form01(form02, form06, form10);
            Form.ActiveForm.Visible = false;
            form01.SendProblem("skip");
            form01.ShowDialog();
        }
    }
}
