using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form08 : Form
    {
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form17 form17;
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private string dataFormName;
        private int[] element;
        private HashSet<int> equation;
        private SortedDictionary<int, HashSet<int>> equations;
        private bool generateClicked = false;
        private int numOfEquations;
        private string output;
        private string problemName;
        public Form08(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06(form07, form08, form09);
            form06.ShowDialog();
        }
        private SortedDictionary<int, HashSet<int>> FillEquations(int numOfEquations, SortedDictionary<int, HashSet<int>> equations)
        {
            Random random = new Random();
            for (int i = 0; i < numOfEquations; i++)
            {
                element = new int[numOfEquations];
                for (int j = 0; j < numOfEquations; j++)
                {
                    element[j] = random.Next(0, 2);
                }
                equation = new HashSet<int>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        equation.Add(j);
                    }
                }
                equations.Add(i, equation);
            }
            return equations;
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (Size.Text == "")
            {
                MessageBox.Show("Please enter size");
            }
            else if (Convert.ToInt32(Size.Text) > 1)
            {
                numOfEquations = Convert.ToInt32(Size.Text);
                equations = new SortedDictionary<int, HashSet<int>>();
                FillEquations(numOfEquations, equations);
                ShowEquations(equations);
                generateClicked = true;
            }
            else
            {
                MessageBox.Show("Size should be > 1");
            }
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (generateClicked == true)
            {
                switch (problemName.Trim())
                {
                    case "Finding the shortest path":
                        Form.ActiveForm.Visible = false;
                        Form18 form18_ = new Form18(form23);
                        form18_.SendData(equations);
                        form18_.SendDataForm(dataFormName);
                        form18_.SendProblem(problemName);
                        form18_.ShowDialog();
                        break;
                    case "Finding probabilities of system states":
                        Form.ActiveForm.Visible = false;
                        Form23 form23_ = new Form23();
                        form23_.SendSystemOfEquationsData(equations);
                        form23_.SendDataForm(dataFormName);
                        form23_.SendProblem(problemName);
                        form23_.ShowDialog();
                        break;
                    case "Finding the minimum weight spanning tree":
                        Form.ActiveForm.Visible = false;
                        Form19 form19_ = new Form19(form23);
                        form19_.SendData(equations);
                        form19_.SendDataForm(dataFormName);
                        form19_.SendProblem(problemName);
                        form19_.ShowDialog();
                        break;
                    case "skip":
                        Form.ActiveForm.Visible = false;
                        Form17 form17 = new Form17(form18, form19);
                        form17.SendData(equations);
                        form17.SendProblem(problemName);
                        form17.ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please generate data");
            }
        }
        public void SendDataForm(string dataForm)
        {
            dataFormName = dataForm;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
        private void ShowEquations(SortedDictionary<int, HashSet<int>> equations)
        {
            output = "";
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                output += "f_" + (equation.Key+1).ToString() + " = (   ";
                foreach (int value in equation.Value)
                {
                    output += "x_" + (value + 1) + "   ";
                }
                output += ")\n";
            }
            Data.Text = output;
        }
        private void Size_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    }
}
