using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form20 : Form
    {
        readonly Form21 form21;
        readonly Form22 form22;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        public Form20(Form21 form21, Form22 form22)
        {
            InitializeComponent();
            this.form21 = form21;
            this.form22 = form22;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm10);
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (Matrix.Checked)
            {
                Form.ActiveForm.Visible = false;
                form21.SendData(commutativeDiagram);
                form21.ShowDialog();
            }
            else if (SystemOfEquations.Checked)
            {
                Form.ActiveForm.Visible = false;
                form22.SendData(commutativeDiagram);
                form22.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        public void SendData(HashSet<Tuple<int, int>> data)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            commutativeDiagram = data;
        }
    }
}
