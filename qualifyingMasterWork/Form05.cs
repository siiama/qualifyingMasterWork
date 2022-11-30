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
    public partial class Form05 : Form
    {
        //Thread thread1, thread2;
        Form14 form14;
        public int size_of_matrix;
        public int[,] matrix;
        public Form05(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
        }
        private void back_Click(object sender, EventArgs e)
        {
            /*thread1 = new Thread(openForm2);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();*/
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            form14.sendData(matrix);
            form14.ShowDialog();
            /*thread2 = new Thread(openForm14);
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
            this.Close();*/
        }
        /*private void openForm2()
        {
            Application.Run(new Form02());
        }
        private void openForm14()
        {
            Application.Run(new Form14());
        }*/
    }
}
