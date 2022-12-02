using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form11 : Form
    {
        readonly Form20 form20;
        private bool chooseFileClicked = false;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private readonly string fileData;
        private readonly int numOfVertexesInEachPart;
        public Form11(Form20 form20)
        {
            InitializeComponent();
            this.form20 = form20;
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = OpenFile.FileName;
            string fileData = System.IO.File.ReadAllText(fileName);
            File.Text = fileName;
            chooseFileClicked = true;
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
            if (chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    //numOfVertexesInEachPart = 
                    commutativeDiagram = new HashSet<Tuple<int, int>>();
                    FillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
                    Form.ActiveForm.Visible = false;
                    form20.SendData(commutativeDiagram);
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
    }
}
