using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form01 : Form
    {
        private string problemName;
        readonly Form01 form01;
        readonly Form02 form02;
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form06 form06;
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form10 form10;
        readonly Form11 form11;
        readonly Form12 form12;
        readonly Form13 form13;
        public Form01(Form02 form02, Form06 form06, Form10 form10)
        {
            InitializeComponent();
            this.form02 = form02;
            this.form06 = form06;
            this.form10 = form10;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form001 form001 = new Form001(form01);
            form001.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (Matrix.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form02 form02 = new Form02(form03, form04, form05);
                form02.SendDataForm("Matrix");
                form02.SendProblem(problemName);
                form02.ShowDialog();
            }
            else if (SystemOfEquations.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form06 form06 = new Form06(form07, form08, form09);
                form06.SendDataForm("System of equations");
                form06.SendProblem(problemName);
                form06.ShowDialog();
            }
            else if (CommutativeDiagram.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form10 form10 = new Form10(form11, form12, form13);
                form10.SendDataForm("Commutative diagram");
                form10.SendProblem(problemName);
                form10.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
