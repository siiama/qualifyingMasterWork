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
            //Form02.ActiveForm.Visible = false;
            //Form.ActiveForm.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                //Form.ActiveForm.Close();
                Form02 form02 = new Form02();
                form02.ShowDialog();
                /*thread1 = new Thread(openForm2);*/
            }
            else if (systemOfEquations.Checked)
            {
                //Form.ActiveForm.Close();
                Form06 form06 = new Form06();
                form06.ShowDialog();
                /*thread2 = new Thread(openForm6);*/
            }
            else if (commutativeDiagram.Checked)
            {
                //Form.ActiveForm.Close();
                Form10 form10 = new Form10();
                form10.ShowDialog();
                /*thread3 = new Thread(openForm10);*/
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
