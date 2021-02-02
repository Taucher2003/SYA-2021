namespace Abfrage
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Senden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BTKinderJugendliche = new System.Windows.Forms.RadioButton();
            this.BTErwachsene = new System.Windows.Forms.RadioButton();
            this.BTSenioren = new System.Windows.Forms.RadioButton();
            this.GBAltersgruppen = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.GBAltersgruppen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Senden
            // 
            this.Senden.Location = new System.Drawing.Point(228, 54);
            this.Senden.Name = "Senden";
            this.Senden.Size = new System.Drawing.Size(75, 23);
            this.Senden.TabIndex = 0;
            this.Senden.Text = "Senden";
            this.Senden.UseVisualStyleBackColor = true;
            this.Senden.Click += new System.EventHandler(this.Senden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nutzung Elektronischer Geräte";
            // 
            // BTKinderJugendliche
            // 
            this.BTKinderJugendliche.AutoSize = true;
            this.BTKinderJugendliche.Location = new System.Drawing.Point(6, 23);
            this.BTKinderJugendliche.Name = "BTKinderJugendliche";
            this.BTKinderJugendliche.Size = new System.Drawing.Size(117, 17);
            this.BTKinderJugendliche.TabIndex = 7;
            this.BTKinderJugendliche.TabStop = true;
            this.BTKinderJugendliche.Text = "Kinder/Jugendliche";
            this.BTKinderJugendliche.UseVisualStyleBackColor = true;
            // 
            // BTErwachsene
            // 
            this.BTErwachsene.AutoSize = true;
            this.BTErwachsene.Location = new System.Drawing.Point(6, 46);
            this.BTErwachsene.Name = "BTErwachsene";
            this.BTErwachsene.Size = new System.Drawing.Size(84, 17);
            this.BTErwachsene.TabIndex = 8;
            this.BTErwachsene.TabStop = true;
            this.BTErwachsene.Text = "Erwachsene";
            this.BTErwachsene.UseVisualStyleBackColor = true;
            // 
            // BTSenioren
            // 
            this.BTSenioren.AutoSize = true;
            this.BTSenioren.Location = new System.Drawing.Point(6, 69);
            this.BTSenioren.Name = "BTSenioren";
            this.BTSenioren.Size = new System.Drawing.Size(67, 17);
            this.BTSenioren.TabIndex = 9;
            this.BTSenioren.TabStop = true;
            this.BTSenioren.Text = "Senioren";
            this.BTSenioren.UseVisualStyleBackColor = true;
            // 
            // GBAltersgruppen
            // 
            this.GBAltersgruppen.Controls.Add(this.BTKinderJugendliche);
            this.GBAltersgruppen.Controls.Add(this.BTSenioren);
            this.GBAltersgruppen.Controls.Add(this.BTErwachsene);
            this.GBAltersgruppen.Location = new System.Drawing.Point(38, 146);
            this.GBAltersgruppen.Name = "GBAltersgruppen";
            this.GBAltersgruppen.Size = new System.Drawing.Size(200, 100);
            this.GBAltersgruppen.TabIndex = 10;
            this.GBAltersgruppen.TabStop = false;
            this.GBAltersgruppen.Text = "Altersgruppen";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Smartphone",
            "Fernsehen",
            "Computer",
            "Spiele Konsolen",
            "Tablet"});
            this.checkedListBox1.Location = new System.Drawing.Point(44, 46);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 298);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.GBAltersgruppen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Senden);
            this.Name = "Form1";
            this.Text = "Abfrage";
            this.GBAltersgruppen.ResumeLayout(false);
            this.GBAltersgruppen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Senden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton BTKinderJugendliche;
        private System.Windows.Forms.RadioButton BTErwachsene;
        private System.Windows.Forms.RadioButton BTSenioren;
        private System.Windows.Forms.GroupBox GBAltersgruppen;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

