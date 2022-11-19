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
    public partial class Form11 : Form
    {
        Thread thread1;
        public Form11()
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

        }
        private void openForm10()
        {
            Application.Run(new Form10());
        }
    }
}
