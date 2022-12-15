namespace qualifyingMasterWork
{
    partial class Form001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form001));
            this.Next = new System.Windows.Forms.Button();
            this.Problem3 = new System.Windows.Forms.RadioButton();
            this.Problem2 = new System.Windows.Forms.RadioButton();
            this.Problem1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(153, 274);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 30);
            this.Next.TabIndex = 19;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Problem3
            // 
            this.Problem3.AutoSize = true;
            this.Problem3.Location = new System.Drawing.Point(53, 199);
            this.Problem3.Name = "Problem3";
            this.Problem3.Size = new System.Drawing.Size(274, 20);
            this.Problem3.TabIndex = 18;
            this.Problem3.Text = "Finding the minimum weight spanning tree";
            this.Problem3.UseVisualStyleBackColor = true;
            // 
            // Problem2
            // 
            this.Problem2.AutoSize = true;
            this.Problem2.Location = new System.Drawing.Point(53, 149);
            this.Problem2.Name = "Problem2";
            this.Problem2.Size = new System.Drawing.Size(248, 20);
            this.Problem2.TabIndex = 16;
            this.Problem2.Text = "Finding probabilities of system states";
            this.Problem2.UseVisualStyleBackColor = true;
            // 
            // Problem1
            // 
            this.Problem1.AutoSize = true;
            this.Problem1.Location = new System.Drawing.Point(53, 99);
            this.Problem1.Name = "Problem1";
            this.Problem1.Size = new System.Drawing.Size(172, 20);
            this.Problem1.TabIndex = 15;
            this.Problem1.Text = "Finding the shortest path";
            this.Problem1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Please choose what problem do you want to solve";
            // 
            // Form001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Problem3);
            this.Controls.Add(this.Problem2);
            this.Controls.Add(this.Problem1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form001";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.RadioButton Problem3;
        private System.Windows.Forms.RadioButton Problem2;
        private System.Windows.Forms.RadioButton Problem1;
        private System.Windows.Forms.Label label1;
    }
}