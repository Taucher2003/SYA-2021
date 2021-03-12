namespace _2021_03_05_IOW_Ampel {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.Panel();
            this.c2 = new System.Windows.Forms.Panel();
            this.c3 = new System.Windows.Forms.Panel();
            this.f1 = new System.Windows.Forms.Panel();
            this.f2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // c1
            // 
            this.c1.Location = new System.Drawing.Point(126, 89);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(25, 26);
            this.c1.TabIndex = 1;
            // 
            // c2
            // 
            this.c2.Location = new System.Drawing.Point(126, 121);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(25, 26);
            this.c2.TabIndex = 2;
            // 
            // c3
            // 
            this.c3.Location = new System.Drawing.Point(126, 153);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(25, 26);
            this.c3.TabIndex = 3;
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(242, 89);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(25, 26);
            this.f1.TabIndex = 4;
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(242, 121);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(25, 26);
            this.f2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(109, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Auto Ampel";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(212, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fußgänger Ampel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.f2);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel c1;
        private System.Windows.Forms.Panel c2;
        private System.Windows.Forms.Panel c3;
        private System.Windows.Forms.Panel f1;
        private System.Windows.Forms.Panel f2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}

