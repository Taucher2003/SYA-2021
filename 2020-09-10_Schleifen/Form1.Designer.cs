namespace _2020_09_10_Schleifen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHeadLoop = new System.Windows.Forms.Button();
            this.buttonFootLoop = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAllLoops = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kopfgesteuerte Schleife";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fußgesteuerte Schleife";
            // 
            // buttonHeadLoop
            // 
            this.buttonHeadLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHeadLoop.Location = new System.Drawing.Point(55, 136);
            this.buttonHeadLoop.Name = "buttonHeadLoop";
            this.buttonHeadLoop.Size = new System.Drawing.Size(205, 37);
            this.buttonHeadLoop.TabIndex = 2;
            this.buttonHeadLoop.Text = "Start";
            this.buttonHeadLoop.UseVisualStyleBackColor = true;
            this.buttonHeadLoop.Click += new System.EventHandler(this.ButtonHeadLoop_Click);
            // 
            // buttonFootLoop
            // 
            this.buttonFootLoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFootLoop.Location = new System.Drawing.Point(55, 233);
            this.buttonFootLoop.Name = "buttonFootLoop";
            this.buttonFootLoop.Size = new System.Drawing.Size(205, 37);
            this.buttonFootLoop.TabIndex = 3;
            this.buttonFootLoop.Text = "Start";
            this.buttonFootLoop.UseVisualStyleBackColor = true;
            this.buttonFootLoop.Click += new System.EventHandler(this.ButtonFootLoop_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(305, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 290);
            this.listBox1.TabIndex = 4;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(55, 381);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(205, 37);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Löschen";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(305, 381);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(205, 37);
            this.buttonQuit.TabIndex = 6;
            this.buttonQuit.Text = "Beenden";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.ButtonQuit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(55, 50);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Zahlen?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonAllLoops
            // 
            this.buttonAllLoops.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllLoops.Location = new System.Drawing.Point(59, 323);
            this.buttonAllLoops.Name = "buttonAllLoops";
            this.buttonAllLoops.Size = new System.Drawing.Size(205, 37);
            this.buttonAllLoops.TabIndex = 9;
            this.buttonAllLoops.Text = "Start";
            this.buttonAllLoops.UseVisualStyleBackColor = true;
            this.buttonAllLoops.Click += new System.EventHandler(this.ButtonAllLoops_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alle Schleifen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 472);
            this.Controls.Add(this.buttonAllLoops);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonFootLoop);
            this.Controls.Add(this.buttonHeadLoop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Schleifen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHeadLoop;
        private System.Windows.Forms.Button buttonFootLoop;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonAllLoops;
        private System.Windows.Forms.Label label3;
    }
}

