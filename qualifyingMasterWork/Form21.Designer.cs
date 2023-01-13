namespace qualifyingMasterWork
{
    partial class Form21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form21));
            this.Save = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(50, 150);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 30);
            this.Save.TabIndex = 91;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(50, 275);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(100, 30);
            this.Finish.TabIndex = 90;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.UseWaitCursor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Result: matrix";
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(200, 100);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(0, 16);
            this.Data.TabIndex = 92;
            // 
            // SaveFile
            // 
            this.SaveFile.FileName = "result";
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch";
            this.Load += new System.EventHandler(this.Form21_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}