namespace qualifyingMasterWork
{
    partial class Form10
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
            this.SuspendLayout();
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.Location = new System.Drawing.Point(150, 247);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(72, 20);
            this.manual.TabIndex = 28;
            this.manual.Text = "manual";
            this.manual.UseVisualStyleBackColor = true;
            // 
            // generate
            // 
            this.generate.AutoSize = true;
            this.generate.Location = new System.Drawing.Point(150, 198);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(82, 20);
            this.generate.TabIndex = 26;
            this.generate.Text = "generate";
            this.generate.UseVisualStyleBackColor = true;
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Location = new System.Drawing.Point(150, 149);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(45, 20);
            this.file.TabIndex = 25;
            this.file.Text = "file";
            this.file.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Input commutative diagram via";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(150, 339);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 24;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Form10";
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton manual;
        private System.Windows.Forms.RadioButton generate;
        private System.Windows.Forms.RadioButton file;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
    }
}