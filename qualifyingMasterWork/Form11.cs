using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form11 : Form
    {
        readonly Form11 form11;
        readonly Form12 form12;
        readonly Form13 form13;
        readonly Form20 form20;
        readonly Form21 form21;
        readonly Form22 form22;
        readonly Form23 form23;
        private string dataFormName;
        private bool chooseFileClicked = false;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private Tuple<int, int> edgeFromFile;
        private string[] edgesFromFile;
        private string fileData;
        private string fileName;
        private string problemName;
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
            Form10 form10 = new Form10(form11, form12, form13);
            form10.SendDataForm(dataFormName);
            form10.SendProblem(problemName);
            form10.ShowDialog();
        }
        private bool CheckDataFromFile()
        {
            //check data from file
            return true;
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            File.Text = System.IO.Path.GetFileName(fileName);
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
                    if (CheckDataFromFile())
                    {
                        commutativeDiagram = new HashSet<Tuple<int, int>>();
                        FillCommutativeDiagram(commutativeDiagram);
                        switch (problemName)
                        {
                            case "Finding the shortest path":
                                Form.ActiveForm.Visible = false;
                                Form21 form21_ = new Form21(form23);
                                form21_.SendData(commutativeDiagram);
                                form21_.SendDataForm(dataFormName);
                                form21_.SendProblem(problemName);
                                form21_.ShowDialog();
                                break;
                            case "Finding probabilities of system states":
                                Form.ActiveForm.Visible = false;
                                Form22 form22_ = new Form22(form23);
                                form22_.SendData(commutativeDiagram);
                                form22_.SendDataForm(dataFormName);
                                form22_.SendProblem(problemName);
                                form22_.ShowDialog();
                                break;
                            case "Finding the minimum weight spanning tree":
                                Form.ActiveForm.Visible = false;
                                Form23 form23_ = new Form23();
                                form23_.SendDataForm(dataFormName);
                                form23_.SendCommutativeDiagramData(commutativeDiagram);
                                form23_.SendProblem(problemName);
                                form23_.ShowDialog();
                                break;
                            case "skip":
                                Form.ActiveForm.Visible = false;
                                Form20 form20 = new Form20(form21, form22);
                                form20.SendData(commutativeDiagram);
                                form20.SendProblem(problemName);
                                form20.ShowDialog();
                                break;
                        }
                    }
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
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
    }
}
