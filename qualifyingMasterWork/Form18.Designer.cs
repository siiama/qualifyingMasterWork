﻿namespace qualifyingMasterWork
{
    partial class Form18
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
            this.Save = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(203, 285);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 86;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(339, 285);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 23);
            this.Finish.TabIndex = 85;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.UseWaitCursor = true;
            this.Finish.Click += new System.EventHandler(this.Finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Result: matrix";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(68, 285);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 83;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(192, 86);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(0, 16);
            this.Data.TabIndex = 88;
            // 
            // SaveFile
            // 
            this.SaveFile.FileName = "result";
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Form18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form18";
            this.Load += new System.EventHandler(this.Form18_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Data;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}