﻿namespace qualifyingMasterWork
{
    partial class Form14
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
            this.CommutativeDiagram = new System.Windows.Forms.RadioButton();
            this.SystemOfEquations = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommutativeDiagram
            // 
            this.CommutativeDiagram.AutoSize = true;
            this.CommutativeDiagram.Location = new System.Drawing.Point(39, 182);
            this.CommutativeDiagram.Name = "CommutativeDiagram";
            this.CommutativeDiagram.Size = new System.Drawing.Size(159, 20);
            this.CommutativeDiagram.TabIndex = 22;
            this.CommutativeDiagram.Text = "Commutative diagram";
            this.CommutativeDiagram.UseVisualStyleBackColor = true;
            // 
            // SystemOfEquations
            // 
            this.SystemOfEquations.AutoSize = true;
            this.SystemOfEquations.Location = new System.Drawing.Point(39, 133);
            this.SystemOfEquations.Name = "SystemOfEquations";
            this.SystemOfEquations.Size = new System.Drawing.Size(149, 20);
            this.SystemOfEquations.TabIndex = 20;
            this.SystemOfEquations.Text = "System of equations";
            this.SystemOfEquations.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Please choose what kind of data do you want to get";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(164, 261);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 70;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.UseWaitCursor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(39, 261);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 69;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CommutativeDiagram);
            this.Controls.Add(this.SystemOfEquations);
            this.Controls.Add(this.label1);
            this.Name = "Form14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton CommutativeDiagram;
        private System.Windows.Forms.RadioButton SystemOfEquations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
    }
}