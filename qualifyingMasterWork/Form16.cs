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
    public partial class Form16 : Form
    {
        Form23 form23;
        public int[,] matrix;
        public int numOfVertexesInEachPart;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public string output, result;
        public Form16(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            save_file.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public void sendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
        }
        private HashSet<Tuple<int, int>> fillCommutativeDiagram(int numOfVertexesInEachPart, HashSet<Tuple<int, int>> commutativeDiagram)
        {
            for (int i=0; i<numOfVertexesInEachPart; i++)
            {
                for (int j=0; j<numOfVertexesInEachPart; j++)
                {
                    if (matrix[i,j] == 1)
                    {
                        Tuple<int, int> edge = new Tuple<int, int>(i, j);
                        commutativeDiagram.Add(edge);
                    }
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
                result += "g_" + (edge.Item1+1) + ", x_" + (edge.Item2+1) + "\n";
            }
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            numOfVertexesInEachPart = matrix.GetLength(0);
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            fillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
            showCommutativeDiagram(commutativeDiagram);
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm14);
        }
        private void finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            form23.ShowDialog();
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
