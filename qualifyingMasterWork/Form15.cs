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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace qualifyingMasterWork
{
    public partial class Form15 : Form
    {
        Form23 form23;
        public int[,] matrix;
        public int num_of_equations;
        public SortedDictionary<int, HashSet<int>> equations;
        public string output, result;
        public Form15(Form23 form23)
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
        private SortedDictionary<int, HashSet<int>> fill_equations(int num_of_equations, SortedDictionary<int, HashSet<int>> equations)
        {
            for (int i = 0; i < num_of_equations; i++)
            {
                int[] element = new int[num_of_equations];
                for (int j = 0; j < num_of_equations; j++)
                {
                    element[j] = matrix[i, j];
                }
                HashSet<int> equation = new HashSet<int>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        equation.Add(j);
                    }
                }
                equations.Add(i + 1, equation);
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
        private void Form15_Load(object sender, EventArgs e)
        {
            num_of_equations = matrix.GetLength(0);
            equations = new SortedDictionary<int, HashSet<int>>();
            fill_equations(num_of_equations, equations);
            show_equations(equations);
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
            if (save_file.ShowDialog() == DialogResult.Cancel)
                return;
            save_equations(equations);
            string filename = save_file.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
    }
}
