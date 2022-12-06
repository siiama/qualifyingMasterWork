namespace qualifyingMasterWork
{
    partial class Form03
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
            this.Next = new System.Windows.Forms.Button();
            this.ChooseFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.file = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(213, 245);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 55;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.UseWaitCursor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ChooseFile
            // 
            this.ChooseFile.Location = new System.Drawing.Point(98, 150);
            this.ChooseFile.Name = "ChooseFile";
            this.ChooseFile.Size = new System.Drawing.Size(91, 23);
            this.ChooseFile.TabIndex = 54;
            this.ChooseFile.Text = "Choose file";
            this.ChooseFile.UseVisualStyleBackColor = true;
            this.ChooseFile.Click += new System.EventHandler(this.ChooseFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Input matrix";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(98, 245);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 52;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(210, 153);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(0, 16);
            this.file.TabIndex = 56;
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.file);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.ChooseFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Form03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button ChooseFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Label file;
    }
}