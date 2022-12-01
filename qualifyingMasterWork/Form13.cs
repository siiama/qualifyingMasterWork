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
    public partial class Form13 : Form
    {
        Thread thread1, thread2;
        public Form13()
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
        private void next_Click(object sender, EventArgs e)
        {
            thread2 = new Thread(openForm20);
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
            this.Close();
        }
        private void openForm10()
        {
            Application.Run(new Form10());
        }

        private void ok_Click(object sender, EventArgs e)
        {

        }

        private void openForm20()
        {
            Application.Run(new Form20());
        }
    }
}
