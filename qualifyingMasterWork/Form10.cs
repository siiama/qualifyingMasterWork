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
    public partial class Form10 : Form
    {
        Thread thread;
        public Form10()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            thread = new Thread(openForm1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        private void openForm1()
        {
            Application.Run(new Form01());
        }
    }
}
