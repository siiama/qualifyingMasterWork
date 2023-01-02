using System;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form05 : Form
    {
        readonly Form03 form03;
        readonly Form04 form04;
        readonly Form05 form05;
        readonly Form14 form14;
        readonly Form15 form15;
        readonly Form16 form16;
        readonly Form23 form23;
        private string dataFormName;
        private string[] elementInRow;
        private int[,] matrix;
        private string problemName;
        private string[] row;
        private int sizeOfMatrix;
        public Form05(Form14 form14)
        {
            InitializeComponent();
            this.form14 = form14;
        }
        private void Back_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Visible = false;
            Form02 form02 = new Form02(form03, form04, form05);
            form02.SendDataForm(dataFormName);
            form02.SendProblem(problemName);
            form02.ShowDialog();
        }
        private bool CheckDataFromManualInput()
        {
            var charsToRemove = new string[] { " ", "." };
            string matrixNumbers = Data.Text.Substring(0, Data.Text.IndexOf('.'));
            foreach (var c in charsToRemove)
            {
                matrixNumbers = matrixNumbers.Replace(c, string.Empty);
            }
            matrixNumbers = matrixNumbers.Replace(";", ",");
            matrixNumbers = matrixNumbers.Replace(Environment.NewLine, string.Empty);
            sizeOfMatrix = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';').Length;
            if (matrixNumbers.Split(',').Length != sizeOfMatrix * sizeOfMatrix)
            {
                MessageBox.Show("Your matrix is not square!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(13)
                && e.KeyChar != Convert.ToChar(32) && e.KeyChar != Convert.ToChar(44) && e.KeyChar != Convert.ToChar(45)
                && e.KeyChar != Convert.ToChar(46) && e.KeyChar != Convert.ToChar(59))
            {
                e.Handled = true;
            }
        }
        private int[,] FillMatrix(int[,] matrix)
        {
            row = new string[matrix.GetLength(0)];
            row = Data.Text.Substring(0, Data.Text.IndexOf('.')).Split(';');
            for (int i = 0; i < row.Length; i++)
            {
                elementInRow = new string[matrix.GetLength(1)];
                var charsToRemove = new string[] { " ", "." };
                foreach (var c in charsToRemove)
                {
                    row[i] = row[i].Replace(c, string.Empty);
                }
                row[i] = row[i].Replace(Environment.NewLine, string.Empty);
                elementInRow = row[i].Split(',');
                for (int j = 0; j < elementInRow.Length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(elementInRow[j]);
                }
            }
            return matrix;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (CheckDataFromManualInput())
            {
                matrix = new int[sizeOfMatrix, sizeOfMatrix];
                FillMatrix(matrix);
                switch (problemName)
                {
                    case "Finding the shortest path":
                        Form.ActiveForm.Visible = false;
                        Form23 form23_ = new Form23();
                        form23_.SendDataForm(dataFormName);
                        form23_.SendMatrixData(matrix);
                        form23_.SendProblem(problemName);
                        form23_.ShowDialog();
                        break;
                    case "Finding probabilities of system states":
                        Form.ActiveForm.Visible = false;
                        Form15 form15_ = new Form15(form23);
                        form15_.SendData(matrix);
                        form15_.SendDataForm(dataFormName);
                        form15_.SendProblem(problemName);
                        form15_.ShowDialog();
                        break;
                    case "Finding the minimum weight spanning tree":
                        Form.ActiveForm.Visible = false;
                        Form16 form16_ = new Form16(form23);
                        form16_.SendData(matrix);
                        form16_.SendDataForm(dataFormName);
                        form16_.SendProblem(problemName);
                        form16_.ShowDialog();
                        break;
                    case "skip":
                        Form.ActiveForm.Visible = false;
                        Form14 form14 = new Form14(form15, form16);
                        form14.SendData(matrix);
                        form14.SendProblem(problemName);
                        form14.ShowDialog();
                        break;
                }
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
