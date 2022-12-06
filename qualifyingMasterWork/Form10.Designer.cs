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
            this.Next = new System.Windows.Forms.Button();
            this.Manual = new System.Windows.Forms.RadioButton();
            this.Generate = new System.Windows.Forms.RadioButton();
            this.File = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(215, 289);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 58;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.UseWaitCursor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Manual
            // 
            this.Manual.AutoSize = true;
            this.Manual.Location = new System.Drawing.Point(96, 197);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(72, 20);
            this.Manual.TabIndex = 57;
            this.Manual.Text = "Manual";
            this.Manual.UseVisualStyleBackColor = true;
            // 
            // Generate
            // 
            this.Generate.AutoSize = true;
            this.Generate.Location = new System.Drawing.Point(96, 148);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(84, 20);
            this.Generate.TabIndex = 55;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            // 
            // File
            // 
            this.File.AutoSize = true;
            this.File.Location = new System.Drawing.Point(96, 99);
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(50, 20);
            this.File.TabIndex = 54;
            this.File.Text = "File";
            this.File.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Input commutative diagram via";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(96, 289);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 53;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.File);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form10";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.RadioButton Manual;
        private System.Windows.Forms.RadioButton Generate;
        private System.Windows.Forms.RadioButton File;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
    }
}