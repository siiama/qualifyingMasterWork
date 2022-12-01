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
    public partial class Form17 : Form
    {
        Form18 form18;
        Form19 form19;
        public SortedDictionary<int, List<int>> equations;
        public Form17(Form18 form18, Form19 form19)
        {
            InitializeComponent();
            this.form18 = form18;
            this.form19 = form19;
            //Form.ActiveForm.Visible = false;
        }
        public void sendData(SortedDictionary<int, List<int>> data)
        {
            equations = new SortedDictionary<int, List<int>>();
            equations = data;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm6);
        }
        private void ok_Click(object sender, EventArgs e)
        {
            if (matrix.Checked)
            {
                form18.sendData(equations);
                form18.ShowDialog();
                //thread2 = new Thread(openForm18);
            }
            else if (commutativeDiagram.Checked)
            {
                form19.sendData(equations);
                form19.ShowDialog();
                //thread3 = new Thread(openForm19);
            }
            else
            {
                MessageBox.Show("Please choose form of data");
            }
        }
    }
}
