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
        private Tuple<int, int> edgeFromFile;
        private string[] edgesFromFile;
        private string fileData;
        private string fileName;
        private string[] vertexInEdges;
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
            fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            File.Text = fileName;
            chooseFileClicked = true;
        }
        private HashSet<Tuple<int, int>> FillCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            edgesFromFile = fileData.Split('\n');
            for (int i = 0; i < edgesFromFile.Length; i++)
            {
                vertexInEdges = edgesFromFile[i].Split(',');
                edgeFromFile = new Tuple<int, int>(Convert.ToInt32(vertexInEdges[0].Substring(vertexInEdges[0].IndexOf('g') + 2)) - 1, Convert.ToInt32(vertexInEdges[1].Substring(vertexInEdges[1].IndexOf('x') + 2)) - 1);
                commutativeDiagram.Add(edgeFromFile);
            }
            return commutativeDiagram;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    commutativeDiagram = new HashSet<Tuple<int, int>>();
                    FillCommutativeDiagram(commutativeDiagram);
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
