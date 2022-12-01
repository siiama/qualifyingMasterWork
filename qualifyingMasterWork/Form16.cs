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
    public partial class Form16 : Form
    {
        Form23 form23;
        public int[,] matrix;
        public Form16(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            //Form.ActiveForm.Visible = false;
            save_file.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public void sendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
        }
        private void Form16_Load(object sender, EventArgs e)
        {

        }
        private void back_Click(object sender, EventArgs e)
        {
            /*thread1 = new Thread(openForm14);*/
        }
        private void finish_Click(object sender, EventArgs e)
        {
            form23.ShowDialog();
            /*thread2 = new Thread(openForm23);*/
        }
        private void save_Click(object sender, EventArgs e)
        {
            /*if (save_file.ShowDialog() == DialogResult.Cancel)
                return;
            //save_commutativeDiagram(commutativeDiagram);
            string filename = save_file.FileName;
            System.IO.File.WriteAllText(filename, result);*/
        }
    }
}
