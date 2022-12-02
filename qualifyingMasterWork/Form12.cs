using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form12 : Form
    {
        readonly Form20 form20;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private bool generateClicked = false;
        private int numOfVertexesInEachPart;
        private string output;
        public Form12(Form20 form20)
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
            Random random = new Random();
            for (int i = 0; i < numOfVertexesInEachPart; i++)
            {
                int[] element = new int[numOfVertexesInEachPart];
                for (int j = 0; j < numOfVertexesInEachPart; j++)
                {
                    element[j] = random.Next(0, 2);
                    if (element[j] == 1)
                    {
                        Tuple<int, int> edge = new Tuple<int, int>(i, j);
                        commutativeDiagram.Add(edge);
                    }
                }
            }
            return commutativeDiagram;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else
            {
                numOfVertexesInEachPart = Convert.ToInt32(Size.Text);
                commutativeDiagram = new HashSet<Tuple<int, int>>();
                FillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                ShowCommutativeDiagram(commutativeDiagram);
                generateClicked = true;
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true && numOfVertexesInEachPart >= 1)
            {
                Form.ActiveForm.Visible = false;
                form20.SendData(commutativeDiagram);
                form20.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        private void ShowCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            output = "";
            Data.Text = output;
        }
        private void Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
