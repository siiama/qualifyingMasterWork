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
    public partial class Form14 : Form
    {
        Form15 form15;
        Form16 form16;
        public int[,] matrix;
        public Form14(Form15 form15, Form16 form16)
        {
            InitializeComponent();
            this.form15 = form15;
            this.form16 = form16;
            //Form.ActiveForm.Visible = false;
        }
        public void sendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm2);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (systemOfEquations.Checked)
            {
                form15.sendData(matrix);
                form15.ShowDialog();
            }
            else if (commutativeDiagram.Checked)
            {
                form16.sendData(matrix);
                form16.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
