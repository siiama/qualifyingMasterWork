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
    public partial class Form06 : Form
    {
        Thread thread1, thread2, thread3, thread4;
        public Form06()
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
        private void openForm1()
        {
            Application.Run(new Form01());
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (file.Checked)
            {
                thread2 = new Thread(openForm7);
                thread2.SetApartmentState(ApartmentState.STA);
                thread2.Start();
                this.Close();
            }
            else if (generate.Checked)
            {
                thread3 = new Thread(openForm8);
                thread3.SetApartmentState(ApartmentState.STA);
                thread3.Start();
                this.Close();
            }
            else if (manual.Checked)
            {
                thread4 = new Thread(openForm9);
                thread4.SetApartmentState(ApartmentState.STA);
                thread4.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose form of input");
            }
        }
        private void openForm7()
        {
            Application.Run(new Form07());
        }
        private void openForm8()
        {
            Application.Run(new Form08());
        }
        private void openForm9()
        {
            Application.Run(new Form09());
        }
    }
}
