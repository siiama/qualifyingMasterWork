﻿namespace qualifyingMasterWork
{
    partial class Form05
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
            this.size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ok_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(99, 117);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(22, 22);
            this.size.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Size";
            // 
            // ok_1
            // 
            this.ok_1.Location = new System.Drawing.Point(171, 280);
            this.ok_1.Name = "ok_1";
            this.ok_1.Size = new System.Drawing.Size(75, 23);
            this.ok_1.TabIndex = 68;
            this.ok_1.Text = "OK";
            this.ok_1.UseVisualStyleBackColor = true;
            this.ok_1.UseWaitCursor = true;
            this.ok_1.Click += new System.EventHandler(this.ok_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Input matrix";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(46, 280);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 66;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(46, 161);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 72;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ok_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Form05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button ok;
    }
}