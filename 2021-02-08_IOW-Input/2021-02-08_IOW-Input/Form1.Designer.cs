namespace _2021_02_08_IOW_Input {
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
            this.labelCurrentInput = new System.Windows.Forms.Label();
            this.panelPin15 = new System.Windows.Forms.Panel();
            this.panelPin16 = new System.Windows.Forms.Panel();
            this.panelPin17 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelCurrentInput
            // 
            this.labelCurrentInput.Location = new System.Drawing.Point(128, 114);
            this.labelCurrentInput.Name = "labelCurrentInput";
            this.labelCurrentInput.Size = new System.Drawing.Size(210, 29);
            this.labelCurrentInput.TabIndex = 0;
            this.labelCurrentInput.Text = "label1";
            // 
            // panelPin15
            // 
            this.panelPin15.BackColor = System.Drawing.Color.DarkRed;
            this.panelPin15.Location = new System.Drawing.Point(128, 210);
            this.panelPin15.Name = "panelPin15";
            this.panelPin15.Size = new System.Drawing.Size(128, 124);
            this.panelPin15.TabIndex = 1;
            // 
            // panelPin16
            // 
            this.panelPin16.BackColor = System.Drawing.Color.DarkRed;
            this.panelPin16.Location = new System.Drawing.Point(292, 210);
            this.panelPin16.Name = "panelPin16";
            this.panelPin16.Size = new System.Drawing.Size(128, 124);
            this.panelPin16.TabIndex = 2;
            // 
            // panelPin17
            // 
            this.panelPin17.BackColor = System.Drawing.Color.DarkRed;
            this.panelPin17.Location = new System.Drawing.Point(449, 210);
            this.panelPin17.Name = "panelPin17";
            this.panelPin17.Size = new System.Drawing.Size(128, 124);
            this.panelPin17.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPin17);
            this.Controls.Add(this.panelPin16);
            this.Controls.Add(this.panelPin15);
            this.Controls.Add(this.labelCurrentInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InitializeWarriorStates);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelPin16;
        private System.Windows.Forms.Panel panelPin17;

        private System.Windows.Forms.Label labelCurrentInput;
        private System.Windows.Forms.Panel panelPin15;

        #endregion
    }
}

