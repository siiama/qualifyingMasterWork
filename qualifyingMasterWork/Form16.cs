using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form16 : Form
    {
        readonly Form23 form23;
        private HashSet<Tuple<int, int>> commutativeDiagram;
        private int[,] matrix;
        private int numOfVertexesInEachPart;
        private string output;
        private string result;
        public Form16(Form23 form23)
        {
            InitializeComponent();
            this.form23 = form23;
            SaveFile.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form23 form23 = new Form23();
            Form16 form16 = new Form16(form23);
            Form15 form15 = new Form15(form23);
            Form14 form14 = new Form14(form15, form16);
            form14.SendData(matrix);
            form14.ShowDialog();
        }
        private HashSet<Tuple<int, int>> FillCommutativeDiagram(int numOfVertexesInEachPart, HashSet<Tuple<int, int>> commutativeDiagram)
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
        private void Finish_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            form23.ShowDialog();
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            numOfVertexesInEachPart = matrix.GetLength(0);
            commutativeDiagram = new HashSet<Tuple<int, int>>();
            FillCommutativeDiagram(numOfVertexesInEachPart, commutativeDiagram);
            ShowCommutativeDiagram(commutativeDiagram);
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
        private void Save_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.Cancel)
                return;
            SaveCommutativeDiagram(commutativeDiagram);
            string filename = SaveFile.FileName;
            System.IO.File.WriteAllText(filename, result);
        }
        public void SendData(int[,] data)
        {
            matrix = new int[data.GetLength(0), data.GetLength(1)];
            matrix = data;
        }
        private void ShowCommutativeDiagram(HashSet<Tuple<int, int>> commutativeDiagram)
        {
            output = "";
            Data.Text = output;
        }
    }
}
