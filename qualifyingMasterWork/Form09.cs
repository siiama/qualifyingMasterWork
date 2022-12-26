using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form09 : Form
    {
        readonly Form07 form07;
        readonly Form08 form08;
        readonly Form09 form09;
        readonly Form17 form17;
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private string dataFormName;
        private SortedDictionary<int, HashSet<int>> equations;
        private int numOfEquations;
        private string problemName;
        public Form09(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form06 form06 = new Form06(form07, form08, form09);
            form06.SendDataForm(dataFormName);
            form06.SendProblem(problemName);
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
            numOfEquations = Data.Text.Split(';').Length;
            string[] equation = new string[numOfEquations];
            equation = Data.Text.Split(';');
            int maxNumOfElements = 0;
            for (int i = 0; i < equation.Length; i++)
            {
                var charsToRemove = new string[] { ",", " ", ".", ":", "f", "x", "_" };
                string equationElements = equation[i];
                foreach (var c in charsToRemove)
                {
                    equationElements = equationElements.Replace(c, string.Empty);
                }
                equationElements = equationElements.Replace(Environment.NewLine, string.Empty);
                if ((equationElements.Length - 1) > maxNumOfElements)
                {
                    maxNumOfElements = equationElements.Length - 1;
                }
            }
            if (numOfEquations >= maxNumOfElements)
            {
                equations = new SortedDictionary<int, HashSet<int>>();
                FillEquations(numOfEquations, equations);
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
                MessageBox.Show("Incorrect data!");
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
    }
}
