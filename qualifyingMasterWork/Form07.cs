using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace qualifyingMasterWork
{
    public partial class Form07 : Form
    {
        readonly Form17 form17;
        private bool chooseFileClicked = false;
        private SortedDictionary<int, HashSet<int>> equations;
        private string fileData;
        private int numOfEquations;
        public Form07(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
            OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        }
        private void Back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm6);
        }
        private void ChooseFile_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = OpenFile.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            File.Text = fileName;
            chooseFileClicked = true;
        }
        private SortedDictionary<int, HashSet<int>> FillEquations(int numOfEquations, SortedDictionary<int, HashSet<int>> equations)
        {
            for (int i = 0; i < numOfEquations; i++)
            {
                int[] element = new int[numOfEquations];
                for (int j = 0; j < numOfEquations; j++)
                {
                    //FILL EQUATIONS
                }
                HashSet<int> equation = new HashSet<int>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        //
                    }
                }
                //
            }
            return equations;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    numOfEquations = fileData.Split('\n').Length;
                    equations = new SortedDictionary<int, HashSet<int>>();
                    FillEquations(numOfEquations, equations);
                    Form.ActiveForm.Visible = false;
                    form17.SendData(equations);
                    form17.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Empty file");
                }
            }
            else
            {
                MessageBox.Show("Please choose file");
            }
        }
    }
}
