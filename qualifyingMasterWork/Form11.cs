﻿using System;
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
        Thread thread1, thread2;
        public Form11()
        {
            InitializeComponent();
            open_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void back_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(openForm10);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            this.Close();
        }
        private void next_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(openForm20);
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
            this.Close();
        }
        private void choose_file_Click(object sender, EventArgs e)
        {
            if (open_file.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = open_file.FileName;
            string fileData = System.IO.File.ReadAllText(fileName);
            file.Text = fileName;
            MessageBox.Show(fileData);
        }
        private void openForm10()
        {
            Application.Run(new Form10());
        }
        private void openForm20()
        {
            Application.Run(new Form20());
        }
    }
}
