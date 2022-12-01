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
    public partial class Form19 : Form
    {
        Form23 form23;
        public int num_of_equations;
        public SortedDictionary<int, HashSet<int>> equations;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public string output, result;
        public Form19(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            //Form.ActiveForm.Visible = false;
            save_file.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public void sendData(SortedDictionary<int, HashSet<int>> data)
        {
            equations = new SortedDictionary<int, HashSet<int>>();
            equations = data;
        }
        private HashSet<Tuple<int, int>> fillCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
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
        private void showCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            output = "";
            data.Text = output;
        }
        private void saveCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            result = "";
            foreach (Tuple<int, int> edge in commutativeDiagram)
            {
                result += "g_" + (edge.Item1 + 1) + ", x_" + (edge.Item2 + 1) + "\n";
            }
        }
        private void Form19_Load(object sender, EventArgs e)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            fillCommutativeDiagram(commutativeDiagram);
            showCommutativeDiagram(commutativeDiagram);
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
            if (save_file.ShowDialog() == DialogResult.Cancel)
                return;
            saveCommutativeDiagram(commutativeDiagram);
            string filename = save_file.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
    }
}
