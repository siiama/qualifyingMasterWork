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
        public Form0()
        {
            InitializeComponent();
        }
        private void start_Click(object sender, EventArgs e)
        {
            Form01 form01 = new Form01();
            form01.ShowDialog();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
