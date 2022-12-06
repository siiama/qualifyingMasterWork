namespace qualifyingMasterWork
{
    partial class Form17
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
            this.Back = new System.Windows.Forms.Button();
            this.CommutativeDiagram = new System.Windows.Forms.RadioButton();
            this.Matrix = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(164, 262);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 75;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.UseWaitCursor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(39, 262);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 74;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CommutativeDiagram
            // 
            this.CommutativeDiagram.AutoSize = true;
            this.CommutativeDiagram.Location = new System.Drawing.Point(39, 183);
            this.CommutativeDiagram.Name = "CommutativeDiagram";
            this.CommutativeDiagram.Size = new System.Drawing.Size(159, 20);
            this.CommutativeDiagram.TabIndex = 73;
            this.CommutativeDiagram.Text = "Commutative diagram";
            this.CommutativeDiagram.UseVisualStyleBackColor = true;
            // 
            // Matrix
            // 
            this.Matrix.AutoSize = true;
            this.Matrix.Location = new System.Drawing.Point(39, 134);
            this.Matrix.Name = "Matrix";
            this.Matrix.Size = new System.Drawing.Size(63, 20);
            this.Matrix.TabIndex = 71;
            this.Matrix.Text = "Matrix";
            this.Matrix.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 16);
            this.label1.TabIndex = 72;
            this.label1.Text = "Please choose what kind of data do you want to get";
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.CommutativeDiagram);
            this.Controls.Add(this.Matrix);
            this.Controls.Add(this.label1);
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.RadioButton CommutativeDiagram;
        private System.Windows.Forms.RadioButton Matrix;
        private System.Windows.Forms.Label label1;
    }
}