﻿namespace qualifyingMasterWork
{
    partial class Form08
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
            this.Size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(99, 117);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(22, 22);
            this.Size.TabIndex = 71;
            this.Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(48, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Size";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(46, 161);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(82, 23);
            this.Generate.TabIndex = 69;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(171, 280);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 68;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.UseWaitCursor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Input system of equations";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(46, 280);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 66;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(246, 50);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(0, 16);
            this.Data.TabIndex = 72;
            // 
            // Form08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Form08";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private new System.Windows.Forms.TextBox Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label Data;
    }
}