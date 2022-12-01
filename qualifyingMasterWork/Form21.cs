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
    public partial class Form21 : Form
    {
        Form23 form23;
        public int sizeOfMatrix;
        public int[,] matrix;
        public HashSet<Tuple<int, int>> commutativeDiagram;
        public string output, result;
        public Form21(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            //Form.ActiveForm.Visible = false;
            saveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        public void sendData(HashSet<Tuple<int, int>> data)
        {
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            commutativeDiagram = data;
        }
        private int[,] fillMatrix(int[,] matrix)
        {
            foreach (Tuple<int, int> edge in commutativeDiagram)
            {
                int i = edge.Item1;
                int j = edge.Item2;
                matrix[i, j] = 1;
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
        private void showMatrix(int[,] matrix)
        {
            output = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    output += matrix[i, j].ToString() + "   ";
                }
                output += "\n";
            }
            data.Text = output;
        }
        private void saveMatrix()
        {
            result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += matrix[i, j].ToString() + " ";
                }
                result += "\n";
            }
        }
        private void Form21_Load(object sender, EventArgs e)
        {
            //sizeOfMatrix = commutativeDiagram.Aggregate((val1, val2) => val1.Item1 > val2.Item1 ? val1 : val2);
            matrix = new int[sizeOfMatrix, sizeOfMatrix];
            fillMatrix(matrix);
            showMatrix(matrix);
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm20);
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (saveFile.ShowDialog() == DialogResult.Cancel)
                return;
            saveMatrix();
            string filename = saveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        private void finish_Click(object sender, EventArgs e)
        {
            form23.ShowDialog();
            //thread2 = new Thread(openForm23);
        }
    }
}
