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
    public partial class Form14 : Form
    {
        Thread thread1, thread2, thread3;
        public Form14()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(openForm2);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            this.Close();
        }
        private void openForm2()
        {
            Application.Run(new Form02());
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (systemOfEquations.Checked)
            {
                thread2 = new Thread(openForm15);
                thread2.SetApartmentState(ApartmentState.STA);
                thread2.Start();
                this.Close();
            }
            else if (commutativeDiagram.Checked)
            {
                thread3 = new Thread(openForm16);
                thread3.SetApartmentState(ApartmentState.STA);
                thread3.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        private void openForm15()
        {
            Application.Run(new Form15());
        }
        private void openForm16()
        {
            Application.Run(new Form16());
        }
    }
}
