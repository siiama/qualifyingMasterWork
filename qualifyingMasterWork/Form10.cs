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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            Form.ActiveForm.Visible = false;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm1);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (file.Checked)
            {
                Form23 form23 = new Form23();
                Form22 form22 = new Form22(form23);
                Form21 form21 = new Form21(form23);
                Form20 form20 = new Form20(form21, form22);
                Form11 form11 = new Form11(form20);
                form11.ShowDialog();
                //thread2 = new Thread(openForm11);
            }
            else if (generate.Checked)
            {
                Form23 form23 = new Form23();
                Form22 form22 = new Form22(form23);
                Form21 form21 = new Form21(form23);
                Form20 form20 = new Form20(form21, form22);
                Form12 form12 = new Form12(form20);
                form12.ShowDialog();
                //thread3 = new Thread(openForm12);
            }
            else if (manual.Checked)
            {
                Form23 form23 = new Form23();
                Form22 form22 = new Form22(form23);
                Form21 form21 = new Form21(form23);
                Form20 form20 = new Form20(form21, form22);
                Form13 form13 = new Form13(form20);
                form13.ShowDialog();
                //thread4 = new Thread(openForm13);
            }
            else
            {
                MessageBox.Show("Please choose form of input");
            }
        }
    }
}
