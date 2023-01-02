using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form06 : Form
    {
        private string dataFormName;
        private string problemName;
        readonly Form02 form02;
        readonly Form06 form06;
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form10 form10;
        readonly Form17 form17;
        public Form06(Form07 form07, Form08 form08, Form09 form09)
        {
            InitializeComponent();
            this.form07 = form07;
            this.form08 = form08;
            this.form09 = form09;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form01 form01 = new Form01(form02, form06, form10);
            form01.SendProblem(problemName);
            form01.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (File.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form07 form07 = new Form07(form17);
                form07.SendDataForm(dataFormName);
                form07.SendProblem(problemName);
                form07.ShowDialog();
            }
            else if (Generate.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form08 form08 = new Form08(form17);
                form08.SendDataForm(dataFormName);
                form08.SendProblem(problemName);
                form08.ShowDialog();
            }
            else if (Manual.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form09 form09 = new Form09(form17);
                form09.SendDataForm(dataFormName);
                form09.SendProblem(problemName);
                form09.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of input");
            }
        }
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
