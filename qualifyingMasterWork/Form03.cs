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
        //Thread thread1, thread2;
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
        private void back_Click(object sender, EventArgs e)
        {
            /*thread1 = new Thread(openForm2);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();*/
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if(chooseFileClicked == true)
            {
                form14.sendData(matrix);
                form14.ShowDialog();
                /*thread2 = new Thread(openForm14);
                thread2.SetApartmentState(ApartmentState.STA);
                thread2.Start();
                this.Close();*/
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
            MessageBox.Show(fileData);
        }
        /*private void openForm2()
        {
            Application.Run(new Form02());
        }
        private void openForm14()
        {
            Application.Run(new Form14());
        }*/
    }
}
