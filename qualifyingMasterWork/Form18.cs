﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form18 : Form
    {
        readonly Form23 form23;
        private SortedDictionary<int, HashSet<int>> equations;
        private int[,] matrix;
        private string output;
        private string result;
        private int sizeOfMatrix;
        public Form18(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm17);
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                int function = equation.Key;
                foreach (int argument in equation.Value)
                {
                    matrix[function, argument] = 1;
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            form23.ShowDialog();
        }
        private void Form18_Load(object sender, EventArgs e)
        {
            sizeOfMatrix = equations.Count();
            matrix = new int[sizeOfMatrix, sizeOfMatrix];
            FillMatrix(matrix);
            ShowMatrix(matrix);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveMatrix();
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void SaveMatrix()
        {
            result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j].ToString() + " ";
                }
                result += "\n";
            }
        }
        public void SendData(SortedDictionary<int, HashSet<int>> data)
        {
            equations = new SortedDictionary<int, HashSet<int>>();
            equations = data;
        }
        private void ShowMatrix(int[,] matrix)
        {
            output = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output += matrix[i, j].ToString() + "   ";
                }
                output += "\n";
            }
            Data.Text = output;
        }
    }
}
