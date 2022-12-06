using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form0 : Form
    {
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
            Form01 form01 = new Form01();
            form01.ShowDialog();
        }
    }
}
