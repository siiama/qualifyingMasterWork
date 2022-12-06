﻿using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form03 : Form
    {
        readonly Form14 form14;
        private bool chooseFileClicked = false;
        private string[] elementInRow;
        private string fileData;
        private string fileName;
        private int[,] matrix;
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
            Form02 form02 = new Form02();
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
