using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                this.Hide();
                Form02 okFrom1_1To2 = new Form02();
                okFrom1_1To2.Show();
            }
            else if (systemOfEquations.Checked)
            {
                this.Hide();
            }
            else if (commutativeDiagram.Checked)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
