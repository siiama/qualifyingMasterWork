using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form23 : Form
    {
        private string problemName;
        public Form23()
        {
            InitializeComponent();
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }

        private void Form23_Load(object sender, EventArgs e)
        {
            Problem.Text = problemName;
        }
    }
}
