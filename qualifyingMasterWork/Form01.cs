using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
            //Form.ActiveForm.Visible = false;
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                Form02 form02 = new Form02();
                form02.ShowDialog();
            }
            else if (systemOfEquations.Checked)
            {
                Form06 form06 = new Form06();
                form06.ShowDialog();
            }
            else if (commutativeDiagram.Checked)
            {
                Form10 form10 = new Form10();
                form10.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
