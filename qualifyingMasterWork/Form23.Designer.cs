namespace qualifyingMasterWork
{
    partial class Form23
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form23));
            this.label1 = new System.Windows.Forms.Label();
            this.Finish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Problem = new System.Windows.Forms.Label();
            this.DataForm = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.Memory = new System.Windows.Forms.Label();
            this.Solution = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Solution of the chosen problem:";
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(125, 275);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(100, 30);
            this.Finish.TabIndex = 8;
            this.Finish.Text = "FINISH";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Problem:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data form:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Memory:";
            // 
            // Problem
            // 
            this.Problem.AutoSize = true;
            this.Problem.Location = new System.Drawing.Point(60, 75);
            this.Problem.Name = "Problem";
            this.Problem.Size = new System.Drawing.Size(0, 16);
            this.Problem.TabIndex = 14;
            // 
            // DataForm
            // 
            this.DataForm.AutoSize = true;
            this.DataForm.Location = new System.Drawing.Point(125, 170);
            this.DataForm.Name = "DataForm";
            this.DataForm.Size = new System.Drawing.Size(0, 16);
            this.DataForm.TabIndex = 15;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(125, 205);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 16);
            this.Time.TabIndex = 16;
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Location = new System.Drawing.Point(125, 240);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(0, 16);
            this.Memory.TabIndex = 17;
            // 
            // Solution
            // 
            this.Solution.AutoSize = true;
            this.Solution.Location = new System.Drawing.Point(60, 125);
            this.Solution.Name = "Solution";
            this.Solution.Size = new System.Drawing.Size(0, 16);
            this.Solution.TabIndex = 18;
            // 
            // Data
            // 
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(300, 50);
            this.Data.Name = "Data";
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 24;
            this.Data.Size = new System.Drawing.Size(440, 255);
            this.Data.TabIndex = 19;
            this.Data.Visible = false;
            // 
            // Form23
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(807, 378);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Solution);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.DataForm);
            this.Controls.Add(this.Problem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Finish);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form23";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch";
            this.Load += new System.EventHandler(this.Form23_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Problem;
        private System.Windows.Forms.Label DataForm;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label Memory;
        private System.Windows.Forms.Label Solution;
        private System.Windows.Forms.DataGridView Data;
    }
}