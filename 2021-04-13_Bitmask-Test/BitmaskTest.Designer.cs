namespace _2021_04_13_Bitmask_Test {
    partial class BitmaskTest {
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.logicOr = new System.Windows.Forms.RadioButton();
            this.logicAnd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(103, 68);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(105, 20);
            this.input1.TabIndex = 0;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(103, 146);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(105, 20);
            this.input2.TabIndex = 1;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(358, 108);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(105, 20);
            this.output.TabIndex = 2;
            // 
            // logicOr
            // 
            this.logicOr.Checked = true;
            this.logicOr.Location = new System.Drawing.Point(229, 86);
            this.logicOr.Name = "logicOr";
            this.logicOr.Size = new System.Drawing.Size(101, 24);
            this.logicOr.TabIndex = 3;
            this.logicOr.TabStop = true;
            this.logicOr.Text = "ODER";
            this.logicOr.UseVisualStyleBackColor = true;
            // 
            // logicAnd
            // 
            this.logicAnd.Location = new System.Drawing.Point(229, 122);
            this.logicAnd.Name = "logicAnd";
            this.logicAnd.Size = new System.Drawing.Size(101, 24);
            this.logicAnd.TabIndex = 4;
            this.logicAnd.Text = "UND";
            this.logicAnd.UseVisualStyleBackColor = true;
            // 
            // BitmaskTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 262);
            this.Controls.Add(this.logicAnd);
            this.Controls.Add(this.logicOr);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Name = "BitmaskTest";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.RadioButton logicAnd;
        private System.Windows.Forms.RadioButton logicOr;
        private System.Windows.Forms.TextBox output;

        #endregion
    }
}

