using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form13 : Form
    {
        readonly Form11 form11;
        readonly Form12 form12;
        readonly Form13 form13;
        readonly Form20 form20;
        readonly Form21 form21;
        readonly Form22 form22;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private bool okClicked = false;
        private int numOfVertexesInEachPart;
        private string problemName;
        public Form13(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form10 form10 = new Form10(form11, form12, form13);
            form10.ShowDialog();
        }
        private HashSet<Tuple<int, int>> FillCommutativeDiagram(int numOfVertexesInEachPart, HashSet<Tuple<int, int>> commutativeDiagram)
        {
            for (int i = 0; i < numOfVertexesInEachPart; i++)
            {
                int[] element = new int[numOfVertexesInEachPart];
                for (int j = 0; j < numOfVertexesInEachPart; j++)
                {
                    //FILL COMMUTATIVE DIAGRAM
                    if (element[j] == 1)
                    {
                        //
                    }
                }
            }
            return commutativeDiagram;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (okClicked == true)// && INPUT IS NOT NULL
            {
                /*Form.ActiveForm.Visible = false;
                Form20 form20 = new Form20(form21, form22);
                form20.SendData(commutativeDiagram);
                form20.SendProblem(problemName);
                form20.ShowDialog();*/
            }
            else
            {
                MessageBox.Show("Please input data");
            }
        }
        
        private void Ok_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(Size.Text) > 1)
            {
                if (Convert.ToInt32(Size.Text) > 10)
                    MessageBox.Show("Are you patient enough to input data manually?");
                numOfVertexesInEachPart = Convert.ToInt32(Size.Text);
                commutativeDiagram = new HashSet<Tuple<int, int>>();
                //DO BUTTONS TO INPUT MANUALLY
                FillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                okClicked = true;
            }
            else
            {
                MessageBox.Show("Size should be > 1");
            }
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
