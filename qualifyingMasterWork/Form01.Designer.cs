namespace qualifyingMasterWork
{
    partial class Form01
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
            this.CommutativeDiagram = new System.Windows.Forms.RadioButton();
            this.SystemOfEquations = new System.Windows.Forms.RadioButton();
            this.Matrix = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(138, 284);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 14;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // CommutativeDiagram
            // 
            this.CommutativeDiagram.AutoSize = true;
            this.CommutativeDiagram.Location = new System.Drawing.Point(56, 203);
            this.CommutativeDiagram.Name = "CommutativeDiagram";
            this.CommutativeDiagram.Size = new System.Drawing.Size(159, 20);
            this.CommutativeDiagram.TabIndex = 13;
            this.CommutativeDiagram.Text = "Commutative diagram";
            this.CommutativeDiagram.UseVisualStyleBackColor = true;
            // 
            // SystemOfEquations
            // 
            this.SystemOfEquations.AutoSize = true;
            this.SystemOfEquations.Location = new System.Drawing.Point(56, 154);
            this.SystemOfEquations.Name = "SystemOfEquations";
            this.SystemOfEquations.Size = new System.Drawing.Size(149, 20);
            this.SystemOfEquations.TabIndex = 11;
            this.SystemOfEquations.Text = "System of equations";
            this.SystemOfEquations.UseVisualStyleBackColor = true;
            // 
            // Matrix
            // 
            this.Matrix.AutoSize = true;
            this.Matrix.Location = new System.Drawing.Point(56, 105);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(63, 20);
            this.Matrix.TabIndex = 10;
            this.Matrix.Text = "Matrix";
            this.Matrix.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Please choose what kind of data do you have";
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.CommutativeDiagram);
            this.Controls.Add(this.SystemOfEquations);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.label1);
            this.Name = "Form01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.RadioButton CommutativeDiagram;
        private System.Windows.Forms.RadioButton SystemOfEquations;
        private System.Windows.Forms.RadioButton Matrix;
        private System.Windows.Forms.Label label1;
    }
}

