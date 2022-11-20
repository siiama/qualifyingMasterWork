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
    public partial class Form18 : Form
    {
        Thread thread1, thread2;
        public Form18()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(openForm17);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(openForm23);
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
            this.Close();
        }
        private void openForm17()
        {
            Application.Run(new Form17());
        }
        private void openForm23()
        {
            Application.Run(new Form23());
        }
    }
}
