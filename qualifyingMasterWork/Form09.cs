using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form09 : Form
    {
        Form17 form17;
        public int num_of_equations;
        public SortedDictionary<int, HashSet<int>> equations;
        public Form09(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
        }
        private SortedDictionary<int, HashSet<int>> fill_equations(int num_of_equations, SortedDictionary<int, HashSet<int>> equations)
        {
            for (int i = 0; i < num_of_equations; i++)
            {
                int[] element = new int[num_of_equations];
                for (int j = 0; j < num_of_equations; j++)
                {
                    //FILL EQUATIONS
                }
                HashSet<int> equation = new HashSet<int>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        //
                    }
                }
                //
            }
            return equations;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm6);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (okClicked == true)// && INPUT IS NOT NULL
            {
                Form.ActiveForm.Visible = false;
                form17.sendData(equations);
                form17.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please input data");
            }
        }
        bool okClicked = false;
        private void ok_Click(object sender, EventArgs e)
        {
            if (size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(size.Text) > 10)
            {
                MessageBox.Show("Are you patient enough to input data manually?");
                //LET USER INPUT DATA ANYWAY
            }
            else
            {
                num_of_equations = Convert.ToInt32(size.Text);
                equations = new SortedDictionary<int, HashSet<int>>();
                //DO BUTTONS TO INPUT MANUALLY
                fill_equations(num_of_equations, equations);
                okClicked = true;
            }
        }
    }
}
