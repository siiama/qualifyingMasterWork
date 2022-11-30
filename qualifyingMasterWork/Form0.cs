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
    public partial class Form0 : Form
    {
        //Thread thread;
        public Form0()
        {
            InitializeComponent();
        }
        private void start_Click(object sender, EventArgs e)
        {
            Form01 form01 = new Form01();
            form01.ShowDialog();
            /*thread = new Thread(openForm1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();*/
        }
        /*private void openForm1()
        {
            Application.Run(new Form01());
        }*/
    }
}
