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
    public partial class Form20 : Form
    {
        Form21 form21;
        Form22 form22;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public Form20(Form21 form21, Form22 form22)
        {
            InitializeComponent();
            this.form21 = form21;
            this.form22 = form22;
        }
        public void sendData(HashSet<Tuple<int, int>> data)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            commutativeDiagram = data;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm10);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                Form.ActiveForm.Visible = false;
                form21.sendData(commutativeDiagram);
                form21.ShowDialog();
            }
            else if (systemOfEquations.Checked)
            {
                Form.ActiveForm.Visible = false;
                form22.sendData(commutativeDiagram);
                form22.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
