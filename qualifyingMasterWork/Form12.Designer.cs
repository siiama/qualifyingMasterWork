namespace qualifyingMasterWork
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.Size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Size
            // 
            this.Size.Location = new System.Drawing.Point(100, 100);
            this.Size.MaxLength = 2;
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(22, 22);
            this.Size.TabIndex = 78;
            this.Size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Size_KeyPress);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Size";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(50, 150);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(100, 30);
            this.Generate.TabIndex = 76;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(200, 275);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 30);
            this.Next.TabIndex = 75;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.UseWaitCursor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 74;
            this.label1.Text = "Input commutative diagram";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(50, 275);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 30);
            this.Back.TabIndex = 73;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(50, 200);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 30);
            this.Save.TabIndex = 82;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.FileName = "commutative_diagram";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch";
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
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog SaveFile;
    }
}