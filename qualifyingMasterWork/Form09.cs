using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form09 : Form
    {
        readonly Form17 form17;
        private SortedDictionary<int, HashSet<int>> equations;
        private int numOfEquations;
        private bool okClicked = false;
        public Form09(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06();
            form06.ShowDialog();
        }
        private SortedDictionary<int, HashSet<int>> FillEquations(int numOfEquations, SortedDictionary<int, HashSet<int>> equations)
        {
            for (int i = 0; i < numOfEquations; i++)
            {
                int[] element = new int[numOfEquations];
                for (int j = 0; j < numOfEquations; j++)
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
        private void Next_Click(object sender, EventArgs e)
        {
            if (okClicked == true)// && INPUT IS NOT NULL
            {
                Form.ActiveForm.Visible = false;
                form17.SendData(equations);
                form17.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please input data");
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(Size.Text) > 10)
            {
                MessageBox.Show("Are you patient enough to input data manually?");
                //LET USER INPUT DATA ANYWAY
            }
            else
            {
                numOfEquations = Convert.ToInt32(Size.Text);
                equations = new SortedDictionary<int, HashSet<int>>();
                //DO BUTTONS TO INPUT MANUALLY
                FillEquations(numOfEquations, equations);
                okClicked = true;
            }
        }
    }
}
