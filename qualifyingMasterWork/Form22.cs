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
    public partial class Form22 : Form
    {
        Form23 form23;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public SortedDictionary<int, HashSet<int>> equations;
        public string output, result;
        public Form22(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            saveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public void sendData(HashSet<Tuple<int, int>> data)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            commutativeDiagram = data;
        }
        private SortedDictionary<int, HashSet<int>> fill_equations(SortedDictionary<int, HashSet<int>> equations)
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
        private void show_equations(SortedDictionary<int, HashSet<int>> equations)
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
            data.Text = output;
        }
        private void save_equations(SortedDictionary<int, HashSet<int>> equations)
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
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm20);
        }
        private void Form22_Load(object sender, EventArgs e)
        {
            equations = new SortedDictionary<int, HashSet<int>>();
            fill_equations(equations);
            show_equations(equations);
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            save_equations(equations);
            string filename = saveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            form23.ShowDialog();
        }
    }
}
