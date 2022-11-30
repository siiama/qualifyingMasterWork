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
    public partial class Form23 : Form
    {
        //Form0 form0;
        public Form23()
        {
            InitializeComponent();
            Form.ActiveForm.Visible = false;
            //this.form0 = form0;
        }
        private void restart_Click(object sender, EventArgs e)
        {
            //Form.ActiveForm.Close();
            Close();
            /*Form0 form0 = new Form0();
            form0.ShowDialog();*/
            /*form0.ShowIcon = true;
            form0.ShowInTaskbar = true;
            form0.Opacity = 1.0;*/
            /*thread = new Thread(openForm1);*/
        }
    }
}
