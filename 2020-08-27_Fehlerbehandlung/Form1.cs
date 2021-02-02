using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_08_27_Fehlerbehandlung {
    public partial class Form1 : Form {

        //Dictionary um die Werte zu speichern
        Dictionary<String, String> dict = new Dictionary<string, string>();

        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            dict.Add(textBox1.Text, textBox2.Text); //Fügt den Wert in das Dictionary hinzu
                                                    //Exception, falls der Wert bereits vorhanden ist
            textBox1.Text = "";                     //Input Felder zurücksetzen
            textBox2.Text = "";                     //Input Felder zurücksetzen
            MessageBox.Show("Hinzugefügt!");
        }

        private void Button2_Click(object sender, EventArgs e) {
            String value = null;                        //Definierung eines Strings, Vorbelegung mit null
            dict.TryGetValue(textBox3.Text, out value); //Wert aus dem Dictionary holen, Ausgabe erfolgt mit
                                                        //der Variable, die mit out markiert ist
            MessageBox.Show(value.ToString());          //Ausgabe des Wertes in einer Messagebox
                                                        //Exception, falls der Wert nicht existiert
        }
    }
}
