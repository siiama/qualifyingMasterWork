using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form02 : Form
    {
        private string dataFormName;
        private string problemName;
        readonly Form02 form02;
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form06 form06;
        readonly Form10 form10;
        readonly Form14 form14;
        public Form02(Form03 form03, Form04 form04, Form05 form05)
        {
            InitializeComponent();
            this.form03 = form03;
            this.form04 = form04;
            this.form05 = form05;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form01 form01 = new Form01(form02, form06, form10);
            form01.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (File.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form03 form03 = new Form03(form14);
                form03.SendDataForm(dataFormName);
                form03.SendProblem(problemName);
                form03.ShowDialog();
            }
            else if (Generate.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form04 form04 = new Form04(form14);
                form04.SendDataForm(dataFormName);
                form04.SendProblem(problemName);
                form04.ShowDialog();
            }
            else if (Manual.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form05 form05 = new Form05(form14);
                form05.SendDataForm(dataFormName);
                form05.SendProblem(problemName);
                form05.ShowDialog();
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
