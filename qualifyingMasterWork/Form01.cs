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
        //Thread thread1, thread2, thread3;
        public Form01()
        {
            InitializeComponent();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                Form02 form02 = new Form02();
                form02.ShowDialog();
                /*thread1 = new Thread(openForm2);
                thread1.SetApartmentState(ApartmentState.STA);
                thread1.Start();
                this.Close();*/
            }
            else if (systemOfEquations.Checked)
            {
                Form06 form06 = new Form06();
                form06.ShowDialog();
                /*thread2 = new Thread(openForm6);
                thread2.SetApartmentState(ApartmentState.STA);
                thread2.Start();
                this.Close();*/
            }
            else if (commutativeDiagram.Checked)
            {
                Form10 form10 = new Form10();
                form10.ShowDialog();
                /*thread3 = new Thread(openForm10);
                thread3.SetApartmentState(ApartmentState.STA);
                thread3.Start();
                this.Close();*/
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        /*private void openForm2()
        {
            Application.Run(new Form02());
        }
        private void openForm6()
        {
            Application.Run(new Form06());
        }
        private void openForm10()
        {
            Application.Run(new Form10());
        }*/
    }
}
