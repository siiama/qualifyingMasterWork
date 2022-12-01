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
    public partial class Form18 : Form
    {
        Form23 form23;
        public int sizeOfMatrix;
        public int[,] matrix;
        public int num_of_equations;
        public SortedDictionary<int, HashSet<int>> equations;
        public string output, result;
        public Form18(Form23 form23)
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
        private int[,] fillMatrix(int[,] matrix)
        {
            foreach (KeyValuePair<int, HashSet<int>> equation in equations)
            {
                int function = equation.Key;
                foreach (int argument in equation.Value)
                {
                    matrix[function, argument] = 1;
                }
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
        private void Form18_Load(object sender, EventArgs e)
        {
            sizeOfMatrix = equations.Count();
            matrix = new int[sizeOfMatrix, sizeOfMatrix];
            fillMatrix(matrix);
            showMatrix(matrix);
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
            saveMatrix();
            string filename = save_file.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
    }
}
