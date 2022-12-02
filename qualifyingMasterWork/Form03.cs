using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form03 : Form
    {
        Form14 form14;
        public int size_of_matrix;
        public int[,] matrix;
        public string fileData;
        public Form03(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
            open_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private int[,] fillMatrix(int[,] matrix)
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
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm2);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if(chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    size_of_matrix = fileData.Split('\n').Length;
                    matrix = new int[size_of_matrix, size_of_matrix];
                    fillMatrix(matrix);
                    Form.ActiveForm.Visible = false;
                    form14.sendData(matrix);
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
        private bool chooseFileClicked = false;
        private void choose_file_Click(object sender, EventArgs e)
        {
            if (open_file.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = open_file.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            file.Text = fileName;
            chooseFileClicked = true;
        }
    }
}
