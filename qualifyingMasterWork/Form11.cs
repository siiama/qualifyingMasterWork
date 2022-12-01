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
    public partial class Form11 : Form
    {
        Form20 form20;
        public int numOfVertexesInEachPart;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public string fileData;
        public Form11(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
            open_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Form.ActiveForm.Visible = false;
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
            if (chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    //numOfVertexesInEachPart = 
                    commutativeDiagram = new HashSet<Tuple<int, int>>();
                    fillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                    form20.sendData(commutativeDiagram);
                    form20.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Empty file");
                }
            }
            else
            {
                MessageBox.Show("Please choose file");
            }
        }
        private bool chooseFileClicked = false;
        private void choose_file_Click(object sender, EventArgs e)
        {
            if (open_file.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = open_file.FileName;
            string fileData = System.IO.File.ReadAllText(fileName);
            file.Text = fileName;
            chooseFileClicked = true;
        }
    }
}
