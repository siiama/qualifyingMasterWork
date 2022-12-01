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
    public partial class Form07 : Form
    {
        Form17 form17;
        public int num_of_equations;
        public SortedDictionary<int, List<int>> equations;
        public string fileData;
        public Form07(Form17 form17)
        {
            InitializeComponent();
            this.form17 = form17;
            open_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Form.ActiveForm.Visible = false;
        }
        private SortedDictionary<int, List<int>> fill_equations(int num_of_equations, SortedDictionary<int, List<int>> equations)
        {
            for (int i = 0; i < num_of_equations; i++)
            {
                int[] element = new int[num_of_equations];
                for (int j = 0; j < num_of_equations; j++)
                {
                    //element[j] = random.Next(0, 2);
                }
                List<int> equation = new List<int>();
                for (int j = 0; j < element.Length; j++)
                {
                    if (element[j] == 1)
                    {
                        //equation.Add(j);
                    }
                }
                //equations.Add(i + 1, equation);
            }
            return equations;
        }
        private void back_Click(object sender, EventArgs e)
        {
            //thread1 = new Thread(openForm6);
        }
        private void next_Click(object sender, EventArgs e)
        {
            if (chooseFileClicked == true)
            {
                if (!string.IsNullOrEmpty(fileData))
                {
                    num_of_equations = fileData.Split('\n').Length;
                    equations = new SortedDictionary<int, List<int>>();
                    fill_equations(num_of_equations, equations);
                    form17.sendData(equations);
                    form17.ShowDialog();
                    /*thread2 = new Thread(openForm17);*/
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
        private bool chooseFileClicked = false;
        private void choose_file_Click(object sender, EventArgs e)
        {
            if (open_file.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = open_file.FileName;
            fileData = System.IO.File.ReadAllText(fileName);
            file.Text = fileName;
            chooseFileClicked = true;
        }
    }
}
