using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form20 : Form
    {
        readonly Form11 form11;
        readonly Form12 form12;
        readonly Form13 form13;
        readonly Form21 form21;
        readonly Form22 form22;
        readonly Form23 form23;
        private SortedSet<Tuple<int, int, int>> commutativeDiagram;
        private string problemName;
        private SortedSet<Tuple<int, int>> vertexes;
        public Form20(Form21 form21, Form22 form22)
        {
            InitializeComponent();
            this.form21 = form21;
            this.form22 = form22;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form10 form10 = new Form10(form11, form12, form13);
            form10.SendProblem(problemName);
            form10.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (Matrix.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form21 form21 = new Form21(form23);
                form21.SendData(commutativeDiagram);
                form21.SendDataVertexesWeights(vertexes);
                form21.SendProblem(problemName);
                form21.ShowDialog();
            }
            else if (SystemOfEquations.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form22 form22 = new Form22(form23);
                form22.SendData(commutativeDiagram);
                form22.SendDataVertexesWeights(vertexes);
                form22.SendProblem(problemName);
                form22.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        public void SendData(SortedSet<Tuple<int, int, int>> data)
        {
            commutativeDiagram = new SortedSet<Tuple<int, int, int>>();
            commutativeDiagram = data;
        }
        public void SendDataVertexesWeights(SortedSet<Tuple<int, int>> dataVertexes)
        {
            vertexes = dataVertexes;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
