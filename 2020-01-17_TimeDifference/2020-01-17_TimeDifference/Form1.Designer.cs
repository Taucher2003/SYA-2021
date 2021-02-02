namespace _2020_01_17_TimeDifference {
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
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.secondsOut = new System.Windows.Forms.TextBox();
            this.minutesOut = new System.Windows.Forms.TextBox();
            this.hoursOut = new System.Windows.Forms.TextBox();
            this.hour1 = new System.Windows.Forms.NumericUpDown();
            this.minute1 = new System.Windows.Forms.NumericUpDown();
            this.second1 = new System.Windows.Forms.NumericUpDown();
            this.second2 = new System.Windows.Forms.NumericUpDown();
            this.minute2 = new System.Windows.Forms.NumericUpDown();
            this.hour2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.hour1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Berechnen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Löschen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // secondsOut
            // 
            this.secondsOut.Location = new System.Drawing.Point(366, 148);
            this.secondsOut.Name = "secondsOut";
            this.secondsOut.Size = new System.Drawing.Size(100, 20);
            this.secondsOut.TabIndex = 10;
            // 
            // minutesOut
            // 
            this.minutesOut.Location = new System.Drawing.Point(260, 148);
            this.minutesOut.Name = "minutesOut";
            this.minutesOut.Size = new System.Drawing.Size(100, 20);
            this.minutesOut.TabIndex = 9;
            // 
            // hoursOut
            // 
            this.hoursOut.Location = new System.Drawing.Point(154, 148);
            this.hoursOut.Name = "hoursOut";
            this.hoursOut.Size = new System.Drawing.Size(100, 20);
            this.hoursOut.TabIndex = 8;
            // 
            // hour1
            // 
            this.hour1.Location = new System.Drawing.Point(154, 54);
            this.hour1.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hour1.Name = "hour1";
            this.hour1.Size = new System.Drawing.Size(100, 20);
            this.hour1.TabIndex = 11;
            // 
            // minute1
            // 
            this.minute1.Location = new System.Drawing.Point(260, 54);
            this.minute1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minute1.Name = "minute1";
            this.minute1.Size = new System.Drawing.Size(100, 20);
            this.minute1.TabIndex = 12;
            // 
            // second1
            // 
            this.second1.Location = new System.Drawing.Point(366, 54);
            this.second1.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.second1.Name = "second1";
            this.second1.Size = new System.Drawing.Size(100, 20);
            this.second1.TabIndex = 13;
            // 
            // second2
            // 
            this.second2.Location = new System.Drawing.Point(366, 89);
            this.second2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.second2.Name = "second2";
            this.second2.Size = new System.Drawing.Size(100, 20);
            this.second2.TabIndex = 16;
            // 
            // minute2
            // 
            this.minute2.Location = new System.Drawing.Point(260, 89);
            this.minute2.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minute2.Name = "minute2";
            this.minute2.Size = new System.Drawing.Size(100, 20);
            this.minute2.TabIndex = 15;
            // 
            // hour2
            // 
            this.hour2.Location = new System.Drawing.Point(154, 89);
            this.hour2.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hour2.Name = "hour2";
            this.hour2.Size = new System.Drawing.Size(100, 20);
            this.hour2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.second2);
            this.Controls.Add(this.minute2);
            this.Controls.Add(this.hour2);
            this.Controls.Add(this.second1);
            this.Controls.Add(this.minute1);
            this.Controls.Add(this.hour1);
            this.Controls.Add(this.secondsOut);
            this.Controls.Add(this.minutesOut);
            this.Controls.Add(this.hoursOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hour1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minute2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hour2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox secondsOut;
        private System.Windows.Forms.TextBox minutesOut;
        private System.Windows.Forms.TextBox hoursOut;
        private System.Windows.Forms.NumericUpDown hour1;
        private System.Windows.Forms.NumericUpDown minute1;
        private System.Windows.Forms.NumericUpDown second1;
        private System.Windows.Forms.NumericUpDown second2;
        private System.Windows.Forms.NumericUpDown minute2;
        private System.Windows.Forms.NumericUpDown hour2;
    }
}

