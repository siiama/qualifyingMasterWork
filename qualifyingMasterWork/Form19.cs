using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form19 : Form
    {
        readonly Form18 form18;
        readonly Form19 form19;
        readonly Form23 form23;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private SortedDictionary<int, HashSet<int>> equations;
        private string output;
        private string problemName;
        private string result;
        public Form19(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form17 form17 = new Form17(form18, form19);
            form17.SendData(equations);
            form17.ShowDialog();
        }
        private HashSet<Tuple<int, int>> FillCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                int function = equation.Key;
                foreach (int argument in equation.Value)
                {
                    Tuple<int, int> edge = new Tuple<int, int>(function, argument);
                    commutativeDiagram.Add(edge);
                }
            }
            return commutativeDiagram;
        }
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form23 form23 = new Form23();
            form23.SendProblem(problemName);
            form23.ShowDialog();
        }
        private void Form19_Load(object sender, EventArgs e)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            FillCommutativeDiagram(commutativeDiagram);
            ShowCommutativeDiagram(commutativeDiagram);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveCommutativeDiagram(commutativeDiagram);
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void SaveCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            result = "";
            foreach (Tuple<int, int> edge in commutativeDiagram)
            {
                result += "g_" + (edge.Item1 + 1) + ", x_" + (edge.Item2 + 1) + "\n";
            }
            result = result.Remove(result.Length - 1);
        }
        public void SendData(SortedDictionary<int, HashSet<int>> data)
        {
            equations = new SortedDictionary<int, HashSet<int>>();
            equations = data;
        }
        public void SendProblem(string problem)
        {
            problemName = problem;
        }
        private void ShowCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            output = "";
            Data.Text = output;
        }
    }
}
