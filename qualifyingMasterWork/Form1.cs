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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void readInputData_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {

            }
            else if (systemOfEquations.Checked)
            {

            }
            else if (commutativeDiagram.Checked)
            {

            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
