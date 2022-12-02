using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form22 : Form
    {
        readonly Form23 form23;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private SortedDictionary<int, HashSet<int>> equations;
        private string output;
        private string result;
        public Form22(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form23 form23 = new Form23();
            Form22 form22 = new Form22(form23);
            Form21 form21 = new Form21(form23);
            Form20 form20 = new Form20(form21, form22);
            form20.SendData(commutativeDiagram);
            form20.ShowDialog();
        }
        private SortedDictionary<int, HashSet<int>> FillEquations(SortedDictionary<int, HashSet<int>> equations)
        {
            int previousFunction = 0;
            HashSet<int> equation = new HashSet<int>();
            foreach (Tuple<int, int> edge in commutativeDiagram)
            {
                int function = edge.Item1;
                int argument = edge.Item2;
                if (function == previousFunction)
                {
                    equation.Add(argument);
                }
                else
                {
                    equations.Add(function, equation);
                    equation.Clear();
                    previousFunction++;
                }
            }
            return equations;
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            form23.ShowDialog();
        }
        private void Form22_Load(object sender, EventArgs e)
        {
            equations = new SortedDictionary<int, HashSet<int>>();
            FillEquations(equations);
            ShowEquations(equations);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveEquations(equations);
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void SaveEquations(SortedDictionary<int, HashSet<int>> equations)
        {
            result = "";
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                result += "f_" + equation.Key.ToString() + ": ";
                foreach (int value in equation.Value)
                {
                    result += "x_" + (value + 1) + " ";
                }
                result += "\n";
            }
        }
        public void SendData(HashSet<Tuple<int, int>> data)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            commutativeDiagram = data;
        }
        private void ShowEquations(SortedDictionary<int, HashSet<int>> equations)
        {
            output = "";
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                output += "f_" + equation.Key.ToString() + " = (   ";
                foreach (int value in equation.Value)
                {
                    output += "x_" + (value + 1) + "   ";
                }
                output += ")\n";
            }
            Data.Text = output;
        }
    }
}
