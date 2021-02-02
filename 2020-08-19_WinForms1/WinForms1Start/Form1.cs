using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms1Start {
    public partial class Form1 : Form {
        /// <summary>
        /// Konstruktor der Klasse Form1
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// Diese Methode setzt den Text von label1 auf den Wert des Textes von textBox1.
        /// </summary>
        /// <param name="sender">
        ///     Die Textbox, deren Text geändert wird.
        /// </param>
        /// <param name="e">
        ///     Argumente, die die Ausführung der Methode beeinflussen könnten. Sind hier aber unbenutzt.
        /// </param>
        private void TextBox1_TextChanged(object sender, EventArgs e) {
            //Ausgabe nur, wenn Input == 10
            if (textBox1.Text.Equals("10"))
                label1.Text = textBox1.Text;
            else
                label1.Text = "Der Wert entspricht nicht dem Wert 10";
        }
    }
}
