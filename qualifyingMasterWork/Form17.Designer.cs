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
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.commutativeDiagram = new System.Windows.Forms.RadioButton();
            this.matrix = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(164, 262);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 75;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.UseWaitCursor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(39, 262);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 74;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // commutativeDiagram
            // 
            this.commutativeDiagram.AutoSize = true;
            this.commutativeDiagram.Location = new System.Drawing.Point(39, 183);
            this.commutativeDiagram.Name = "commutativeDiagram";
            this.commutativeDiagram.Size = new System.Drawing.Size(157, 20);
            this.commutativeDiagram.TabIndex = 73;
            this.commutativeDiagram.Text = "commutative diagram";
            this.commutativeDiagram.UseVisualStyleBackColor = true;
            // 
            // matrix
            // 
            this.matrix.AutoSize = true;
            this.matrix.Location = new System.Drawing.Point(39, 134);
            this.matrix.Name = "matrix";
            this.matrix.Size = new System.Drawing.Size(63, 20);
            this.matrix.TabIndex = 71;
            this.matrix.Text = "matrix";
            this.matrix.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.next);
            this.Controls.Add(this.back);
            this.Controls.Add(this.commutativeDiagram);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.label1);
            this.Name = "Form17";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.RadioButton commutativeDiagram;
        private System.Windows.Forms.RadioButton matrix;
        private System.Windows.Forms.Label label1;
    }
}