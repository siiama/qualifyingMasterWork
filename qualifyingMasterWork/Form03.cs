using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form03 : Form
    {
        readonly Form14 form14;
        private bool chooseFileClicked = false;
        private string fileData;
        private int[,] matrix;
        private int sizeOfMatrix;
        public Form03(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm2);
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            file.Text = fileName;
            chooseFileClicked = true;
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //FILL MATRIX
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
                    Form.ActiveForm.Visible = false;
                    form14.SendData(matrix);
                    form14.ShowDialog();
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
