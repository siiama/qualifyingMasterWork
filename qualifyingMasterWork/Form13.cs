using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form13 : Form
    {
        readonly Form20 form20;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private bool okClicked = false;
        private int numOfVertexesInEachPart;
        public Form13(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm10);
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
                Form.ActiveForm.Visible = false;
                form20.SendData(commutativeDiagram);
                form20.ShowDialog();
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
            else if (Convert.ToInt32(Size.Text) > 10)
            {
                MessageBox.Show("Are you patient enough to input data manually?");
                //LET USER INPUT DATA ANYWAY
            }
            else
            {
                numOfVertexesInEachPart = Convert.ToInt32(Size.Text);
                commutativeDiagram = new HashSet<Tuple<int, int>>();
                //DO BUTTONS TO INPUT MANUALLY
                FillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                okClicked = true;
            }
        }
    }
}
