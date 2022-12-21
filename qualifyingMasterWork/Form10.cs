using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form10 : Form
    {
        private string dataFormName;
        private string problemName;
        readonly Form02 form02;
        readonly Form06 form06;
        readonly Form10 form10;
        readonly Form11 form11;
        readonly Form12 form12;
        readonly Form13 form13;
        readonly Form20 form20;
        public Form10(Form11 form11, Form12 form12, Form13 form13)
        {
            InitializeComponent();
            this.form11 = form11;
            this.form12 = form12;
            this.form13 = form13;
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
                Form11 form11 = new Form11(form20);
                form11.SendDataForm(dataFormName);
                form11.SendProblem(problemName);
                form11.ShowDialog();
            }
            else if (Generate.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form12 form12 = new Form12(form20);
                form12.SendDataForm(dataFormName);
                form12.SendProblem(problemName);
                form12.ShowDialog();
            }
            else if (Manual.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form13 form13 = new Form13(form20);
                form13.SendDataForm(dataFormName);
                form13.SendProblem(problemName);
                form13.ShowDialog();
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
