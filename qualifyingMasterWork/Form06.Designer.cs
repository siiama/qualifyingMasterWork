﻿namespace qualifyingMasterWork
{
    partial class Form06
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
            this.manual = new System.Windows.Forms.RadioButton();
            this.generate = new System.Windows.Forms.RadioButton();
            this.file = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Location = new System.Drawing.Point(105, 197);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(72, 20);
            this.manual.TabIndex = 23;
            this.manual.Text = "manual";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.AutoSize = true;
            this.generate.Location = new System.Drawing.Point(105, 148);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(82, 20);
            this.generate.TabIndex = 21;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(105, 99);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(45, 20);
            this.file.TabIndex = 20;
            this.file.Text = "file";
            this.file.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Input system of equations via";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(105, 289);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 19;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(223, 289);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 49;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.UseWaitCursor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Form06";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form06";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton manual;
        private System.Windows.Forms.RadioButton generate;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button ok;
    }
}