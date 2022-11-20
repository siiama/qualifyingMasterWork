using System;
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
    public partial class Form20 : Form
    {
        Thread thread1, thread2, thread3;
        public Form20()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(openForm10);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                thread2 = new Thread(openForm21);
                thread2.SetApartmentState(ApartmentState.STA);
                thread2.Start();
                this.Close();
            }
            else if (systemOfEquations.Checked)
            {
                thread3 = new Thread(openForm22);
                thread3.SetApartmentState(ApartmentState.STA);
                thread3.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        private void openForm10()
        {
            Application.Run(new Form10());
        }
        private void openForm21()
        {
            Application.Run(new Form21());
        }
        private void openForm22()
        {
            Application.Run(new Form22());
        }
    }
}
