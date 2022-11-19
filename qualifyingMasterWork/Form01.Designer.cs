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
            this.ok = new System.Windows.Forms.Button();
            this.commutativeDiagram = new System.Windows.Forms.RadioButton();
            this.systemOfEquations = new System.Windows.Forms.RadioButton();
            this.matrix = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(138, 284);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 14;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // commutativeDiagram
            // 
            this.commutativeDiagram.AutoSize = true;
            this.commutativeDiagram.Location = new System.Drawing.Point(56, 203);
            this.commutativeDiagram.Name = "commutativeDiagram";
            this.commutativeDiagram.Size = new System.Drawing.Size(157, 20);
            this.commutativeDiagram.TabIndex = 13;
            this.commutativeDiagram.Text = "commutative diagram";
            this.commutativeDiagram.UseVisualStyleBackColor = true;
            // 
            // systemOfEquations
            // 
            this.systemOfEquations.AutoSize = true;
            this.systemOfEquations.Location = new System.Drawing.Point(56, 154);
            this.systemOfEquations.Name = "systemOfEquations";
            this.systemOfEquations.Size = new System.Drawing.Size(147, 20);
            this.systemOfEquations.TabIndex = 11;
            this.systemOfEquations.Text = "system of equations";
            this.systemOfEquations.UseVisualStyleBackColor = true;
            // 
            // matrix
            // 
            this.matrix.AutoSize = true;
            this.matrix.Location = new System.Drawing.Point(56, 105);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(63, 20);
            this.matrix.TabIndex = 10;
            this.matrix.Text = "matrix";
            this.matrix.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.ok);
            this.Controls.Add(this.commutativeDiagram);
            this.Controls.Add(this.systemOfEquations);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.label1);
            this.Name = "Form01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.RadioButton commutativeDiagram;
        private System.Windows.Forms.RadioButton systemOfEquations;
        private System.Windows.Forms.RadioButton matrix;
        private System.Windows.Forms.Label label1;
    }
}

