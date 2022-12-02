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
    public partial class Form13 : Form
    {
        Form20 form20;
        public int numOfVertexesInEachPart;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public Form13(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
        }
        private HashSet<Tuple<int, int>> fillCommutativeDiagram(int numOfVertexesInEachPart, HashSet<Tuple<int, int>> commutativeDiagram)
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
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm10);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (okClicked == true)// && INPUT IS NOT NULL
            {
                Form.ActiveForm.Visible = false;
                form20.sendData(commutativeDiagram);
                form20.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please input data");
            }
        }
        bool okClicked = false;
        private void ok_Click(object sender, EventArgs e)
        {
            if (size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(size.Text) > 10)
            {
                MessageBox.Show("Are you patient enough to input data manually?");
                //LET USER INPUT DATA ANYWAY
            }
            else
            {
                numOfVertexesInEachPart = Convert.ToInt32(size.Text);
                commutativeDiagram = new HashSet<Tuple<int, int>>();
                //DO BUTTONS TO INPUT MANUALLY
                fillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                okClicked = true;
            }
        }
    }
}
