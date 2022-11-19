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
            this.ok = new System.Windows.Forms.Button();
            this.choose_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(213, 245);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 55;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.UseWaitCursor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // choose_file
            // 
            this.choose_file.Location = new System.Drawing.Point(98, 150);
            this.choose_file.Name = "choose_file";
            this.choose_file.Size = new System.Drawing.Size(91, 23);
            this.choose_file.TabIndex = 54;
            this.choose_file.Text = "choose file";
            this.choose_file.UseVisualStyleBackColor = true;
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
            // back
            // 
            this.back.Location = new System.Drawing.Point(98, 245);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 52;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.choose_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Form03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button choose_file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}