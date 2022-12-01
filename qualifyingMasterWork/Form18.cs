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
    public partial class Form18 : Form
    {
        Form23 form23;
        public int[,] matrix;
        public int num_of_equations;
        public SortedDictionary<int, List<int>> equations;
        public Form18(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            //Form.ActiveForm.Visible = false;
            save_file.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public void sendData(SortedDictionary<int, List<int>> data)
        {
            equations = new SortedDictionary<int, List<int>>();
            equations = data;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm17);
        }
        private void finish_Click(object sender, EventArgs e)
        {
            form23.ShowDialog();
            //thread2 = new Thread(openForm23);
        }
        private void save_Click(object sender, EventArgs e)
        {
            /*if (save_file.ShowDialog() == DialogResult.Cancel)
                return;
            save_matrix(matrix);
            string filename = save_file.FileName;
            System.IO.File.WriteAllText(filename, result);*/
        }
    }
}
