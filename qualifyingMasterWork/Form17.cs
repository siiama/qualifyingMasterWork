using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form17 : Form
    {
        readonly Form18 form18;
        readonly Form19 form19;
        private SortedDictionary<int, HashSet<int>> equations;
        public Form17(Form18 form18, Form19 form19)
        {
            InitializeComponent();
            this.form18 = form18;
            this.form19 = form19;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06();
            form06.ShowDialog();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (Matrix.Checked)
            {
                Form.ActiveForm.Visible = false;
                form18.SendData(equations);
                form18.ShowDialog();
            }
            else if (CommutativeDiagram.Checked)
            {
                Form.ActiveForm.Visible = false;
                form19.SendData(equations);
                form19.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
        public void SendData(SortedDictionary<int, HashSet<int>> data)
        {
            equations = new SortedDictionary<int, HashSet<int>>();
            equations = data;
        }
    }
}
