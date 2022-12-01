using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form12 : Form
    {
        Form20 form20;
        public int numOfVertexesInEachPart;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public Form12(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
            //Form.ActiveForm.Visible = false;
        }
        private HashSet<Tuple<int, int>> fillCommutativeDiagram(int numOfVertexesInEachPart, HashSet<Tuple<int, int>> commutativeDiagram)
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
        private void showCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            string output = "";
            data.Text = output;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm10);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true && numOfVertexesInEachPart >= 1)
            {
                form20.sendData(commutativeDiagram);
                form20.ShowDialog();
                /*thread2 = new Thread(openForm20);*/
            }
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        private void size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        private bool generateClicked = false;
        private void generate_Click(object sender, EventArgs e)
        {
            if (size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else
            {
                numOfVertexesInEachPart = Convert.ToInt32(size.Text);
                commutativeDiagram = new HashSet<Tuple<int, int>>();
                fillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                showCommutativeDiagram(commutativeDiagram);
                generateClicked = true;
            }
        }
    }
}
