namespace qualifyingMasterWork
{
    partial class Form21
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
            this.save = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(203, 285);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 91;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(339, 285);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 23);
            this.finish.TabIndex = 90;
            this.finish.Text = "Finish";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.UseWaitCursor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 89;
            this.label1.Text = "Result: matrix";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(68, 285);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 88;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(192, 80);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(0, 16);
            this.data.TabIndex = 92;
            // 
            // saveFile
            // 
            this.saveFile.FileName = "result";
            // 
            // Form21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.data);
            this.Controls.Add(this.save);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Name = "Form21";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form21";
            this.Load += new System.EventHandler(this.Form21_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}