﻿using System;
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
    public partial class Form16 : Form
    {
        //Thread thread1, thread2;
        Form23 form23;
        public Form16(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
        }
        private void back_Click(object sender, EventArgs e)
        {
            /*thread1 = new Thread(openForm14);
            thread1.SetApartmentState(ApartmentState.STA);
            thread1.Start();*/
            this.Close();
        }
        private void ok_Click(object sender, EventArgs e)
        {
            form23.ShowDialog();
            /*thread2 = new Thread(openForm23);
            thread2.SetApartmentState(ApartmentState.STA);
            thread2.Start();
            this.Close();*/
        }
        /*private void openForm14()
        {
            Application.Run(new Form14());
        }
        private void openForm23()
        {
            Application.Run(new Form23());
        }*/
    }
}
