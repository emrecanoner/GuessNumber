namespace sayıtut
{
    partial class Form1
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
            this.lblsayi = new System.Windows.Forms.Label();
            this.btntahmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsayi
            // 
            this.lblsayi.AutoSize = true;
            this.lblsayi.Location = new System.Drawing.Point(108, 102);
            this.lblsayi.Name = "lblsayi";
            this.lblsayi.Size = new System.Drawing.Size(0, 13);
            this.lblsayi.TabIndex = 0;
            this.lblsayi.Click += new System.EventHandler(this.label1_Click);
            // 
            // btntahmin
            // 
            this.btntahmin.Location = new System.Drawing.Point(84, 135);
            this.btntahmin.Name = "btntahmin";
            this.btntahmin.Size = new System.Drawing.Size(104, 78);
            this.btntahmin.TabIndex = 1;
            this.btntahmin.Text = "TahminEt";
            this.btntahmin.UseVisualStyleBackColor = true;
            this.btntahmin.Click += new System.EventHandler(this.btntahmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btntahmin);
            this.Controls.Add(this.lblsayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsayi;
        private System.Windows.Forms.Button btntahmin;
    }
}

