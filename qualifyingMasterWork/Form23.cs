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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }
        private void restart_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
        }
    }
}
