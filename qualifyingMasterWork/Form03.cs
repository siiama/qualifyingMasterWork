using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form03 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form14 form14;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private string dataFormName;
        private bool chooseFileClicked = false;
        private string[] elementInRow;
        private string fileData;
        private string fileName;
        private int[,] matrix;
        private string problemName;
        private string[] row;
        private int sizeOfMatrix;
        public Form03(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02(form03, form04, form05);
            form02.SendDataForm(dataFormName);
            form02.SendProblem(problemName);
            form02.ShowDialog();
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            file.Text = System.IO.Path.GetFileName(fileName);
            chooseFileClicked = true;
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            row = new string[matrix.GetLength(0)];
            row = fileData.Split('\n');
            for (int i = 0; i < row.Length; i++)
            {
                elementInRow = new string[matrix.GetLength(1)];
                elementInRow = row[i].Split(' ');
                for (int j = 0; j < elementInRow.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(elementInRow[j]);
                }
            }
            return matrix;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if(chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    sizeOfMatrix = fileData.Split('\n').Length;
                    matrix = new int[sizeOfMatrix, sizeOfMatrix];
                    FillMatrix(matrix);
                    switch (problemName.Trim())
                    {
                        case "Finding the shortest path":
                            Form.ActiveForm.Visible = false;
                            Form23 form23_ = new Form23();
                            form23_.SendDataForm(dataFormName);
                            form23_.SendMatrixData(matrix);
                            form23_.SendProblem(problemName);
                            form23_.ShowDialog();
                            break;
                        case "Finding probabilities of system states":
                            Form.ActiveForm.Visible = false;
                            Form15 form15_ = new Form15(form23);
                            form15_.SendData(matrix);
                            form15_.SendDataForm(dataFormName);
                            form15_.SendProblem(problemName);
                            form15_.ShowDialog();
                            break;
                        case "Finding the minimum weight spanning tree":
                            Form.ActiveForm.Visible = false;
                            Form16 form16_ = new Form16(form23);
                            form16_.SendData(matrix);
                            form16_.SendDataForm(dataFormName);
                            form16_.SendProblem(problemName);
                            form16_.ShowDialog();
                            break;
                        case "skip":
                            Form.ActiveForm.Visible = false;
                            Form14 form14 = new Form14(form15, form16);
                            form14.SendData(matrix);
                            form14.SendProblem(problemName);
                            form14.ShowDialog();
                            break;
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
