using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form17 : Form
    {
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private SortedDictionary<int, SortedSet<int>> equations;
        private string problemName;
        public Form17(Form18 form18, Form19 form19)
        {
            InitializeComponent();
            this.form18 = form18;
            this.form19 = form19;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06(form07, form08, form09);
            form06.SendProblem(problemName);
            form06.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (Matrix.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form18 form18 = new Form18(form23);
                form18.SendData(equations);
                form18.SendProblem(problemName);
                form18.ShowDialog();
            }
            else if (CommutativeDiagram.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form19 form19 = new Form19(form23);
                form19.SendData(equations);
                form19.SendProblem(problemName);
                form19.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        public void SendData(SortedDictionary<int, SortedSet<int>> data)
        {
            equations = new SortedDictionary<int, SortedSet<int>>();
            equations = data;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
