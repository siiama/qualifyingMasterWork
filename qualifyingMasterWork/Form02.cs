﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form02 : Form
    {
        public Form02()
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
                Form16 form16 = new Form16(form23);
                Form15 form15 = new Form15(form23);
                Form14 form14 = new Form14(form15, form16);
                Form03 form03 = new Form03(form14);
                form03.ShowDialog();
            }
            else if (generate.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form16 form16 = new Form16(form23);
                Form15 form15 = new Form15(form23);
                Form14 form14 = new Form14(form15, form16);
                Form04 form04 = new Form04(form14);
                form04.ShowDialog();
            }
            else if (manual.Checked)
            {
                Form.ActiveForm.Visible = false;
                Form23 form23 = new Form23();
                Form16 form16 = new Form16(form23);
                Form15 form15 = new Form15(form23);
                Form14 form14 = new Form14(form15, form16);
                Form05 form05 = new Form05(form14);
                form05.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of input");
            }
        }
    }
}
