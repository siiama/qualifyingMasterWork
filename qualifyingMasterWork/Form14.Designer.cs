namespace qualifyingMasterWork
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
            this.commutativeDiagram = new System.Windows.Forms.RadioButton();
            this.systemOfEquations = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // commutativeDiagram
            // 
            this.commutativeDiagram.AutoSize = true;
            this.commutativeDiagram.Location = new System.Drawing.Point(39, 182);
            this.commutativeDiagram.Name = "commutativeDiagram";
            this.commutativeDiagram.Size = new System.Drawing.Size(157, 20);
            this.commutativeDiagram.TabIndex = 22;
            this.commutativeDiagram.Text = "commutative diagram";
            this.commutativeDiagram.UseVisualStyleBackColor = true;
            // 
            // systemOfEquations
            // 
            this.systemOfEquations.AutoSize = true;
            this.systemOfEquations.Location = new System.Drawing.Point(39, 133);
            this.systemOfEquations.Name = "systemOfEquations";
            this.systemOfEquations.Size = new System.Drawing.Size(147, 20);
            this.systemOfEquations.TabIndex = 20;
            this.systemOfEquations.Text = "system of equations";
            this.systemOfEquations.UseVisualStyleBackColor = true;
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
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(164, 261);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 70;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.UseWaitCursor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(39, 261);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 69;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.back);
            this.Controls.Add(this.commutativeDiagram);
            this.Controls.Add(this.systemOfEquations);
            this.Controls.Add(this.label1);
            this.Name = "Form14";
            this.Text = "Form14";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton commutativeDiagram;
        private System.Windows.Forms.RadioButton systemOfEquations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button back;
    }
}