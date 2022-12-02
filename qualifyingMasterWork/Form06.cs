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
    public partial class Form06 : Form
    {
        public Form06()
        {
            InitializeComponent();
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm1);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (file.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form19 form19 = new Form19(form23);
                Form18 form18 = new Form18(form23);
                Form17 form17 = new Form17(form18, form19);
                Form07 form07 = new Form07(form17);
                form07.ShowDialog();
            }
            else if (generate.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form19 form19 = new Form19(form23);
                Form18 form18 = new Form18(form23);
                Form17 form17 = new Form17(form18, form19);
                Form08 form08 = new Form08(form17);
                form08.ShowDialog();
            }
            else if (manual.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form19 form19 = new Form19(form23);
                Form18 form18 = new Form18(form23);
                Form17 form17 = new Form17(form18, form19);
                Form09 form09 = new Form09(form17);
                form09.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of input");
            }
        }
    }
}
