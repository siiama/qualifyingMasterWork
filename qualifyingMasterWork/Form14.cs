using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form14 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private int[,] matrix;
        private SortedSet<Tuple<int, int>> vertexes;
        private string problemName;
        public Form14(Form15 form15, Form16 form16)
        {
            InitializeComponent();
            this.form15 = form15;
            this.form16 = form16;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02(form03, form04, form05);
            form02.SendProblem(problemName);
            form02.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (SystemOfEquations.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form15 form15 = new Form15(form23);
                form15.SendData(matrix);
                form15.SendDataVertexesWeights(vertexes);
                form15.SendProblem(problemName);
                form15.ShowDialog();
            }
            else if (CommutativeDiagram.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form16 form16 = new Form16(form23);
                form16.SendData(matrix);
                form16.SendDataVertexesWeights(vertexes);
                form16.SendProblem(problemName);
                form16.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        public void SendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
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
