using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form0 : Form
    {
        readonly Form01 form01;
        public Form0()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            Form001 form001 = new Form001(form01);
            form001.ShowDialog();
        }
    }
}
