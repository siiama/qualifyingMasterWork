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
    public partial class Form17 : Form
    {
        Thread thread1, thread2, thread3;
        public Form17()
        {
            InitializeComponent();
        }
        private void back_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(openForm6);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                thread2 = new Thread(openForm18);
                thread2.SetApartmentState(ApartmentState.STA);
                thread2.Start();
                this.Close();
            }
            else if (commutativeDiagram.Checked)
            {
                thread3 = new Thread(openForm19);
                thread3.SetApartmentState(ApartmentState.STA);
                thread3.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        private void openForm6()
        {
            Application.Run(new Form06());
        }
        private void openForm18()
        {
            Application.Run(new Form18());
        }
        private void openForm19()
        {
            Application.Run(new Form19());
        }
    }
}
