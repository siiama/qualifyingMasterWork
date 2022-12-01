namespace qualifyingMasterWork
{
    partial class Form11
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
            this.next = new System.Windows.Forms.Button();
            this.choose_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.Label();
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(213, 245);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 71;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.UseWaitCursor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // choose_file
            // 
            this.choose_file.Location = new System.Drawing.Point(98, 150);
            this.choose_file.Name = "choose_file";
            this.choose_file.Size = new System.Drawing.Size(91, 23);
            this.choose_file.TabIndex = 70;
            this.choose_file.Text = "choose file";
            this.choose_file.UseVisualStyleBackColor = true;
            this.choose_file.Click += new System.EventHandler(this.choose_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 69;
            this.label1.Text = "Input commutative diagram";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(98, 245);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 68;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(210, 157);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(0, 16);
            this.file.TabIndex = 72;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.file);
            this.Controls.Add(this.next);
            this.Controls.Add(this.choose_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button choose_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label file;
        private System.Windows.Forms.OpenFileDialog open_file;
    }
}