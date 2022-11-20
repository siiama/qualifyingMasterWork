using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form02 : Form
    {
        Thread thread1, thread2, thread3, thread4;
        public Form02()
        {
            InitializeComponent();
        }
        private void back_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(openForm1);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (file.Checked)
            {
                thread2 = new Thread(openForm3);
                thread2.SetApartmentState(ApartmentState.STA);
                thread2.Start();
                this.Close();
            }
            else if (generate.Checked)
            {
                thread3 = new Thread(openForm4);
                thread3.SetApartmentState(ApartmentState.STA);
                thread3.Start();
                this.Close();
            }
            else if (manual.Checked)
            {
                thread4 = new Thread(openForm5);
                thread4.SetApartmentState(ApartmentState.STA);
                thread4.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose form of input");
            }
        }
        private void openForm1()
        {
            Application.Run(new Form01());
        }
        private void openForm3()
        {
            Application.Run(new Form03());
        }
        private void openForm4()
        {
            Application.Run(new Form04());
        }
        private void openForm5()
        {
            Application.Run(new Form05());
        }
    }
}
