using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abfrage {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Senden_Click(object sender, EventArgs e) {
            String output = "";                                 //Definierung der Output Variable
            foreach(String cb in checkedListBox1.CheckedItems)  //Jedes ausgewählte Element durchgehen
                output += ", " + cb;                            //Füge die ausgewählten Werte in den Output hinzu
            if (output.Equals(""))                              //Falls Output leer
                output = ", Keine Geräte ausgewählt";           // -> Belegung mit "Keine Geräte ausgewählt"

            if (BTKinderJugendliche.Checked)                    //Abfrage nach der Altersgruppe Kinder
                output += "\n\nAltersgruppe: Kinder/Jugendliche";
            if (BTKinderJugendliche.Checked)                    //Abfrage nach der Altersgruppe Erwachsene
                output += "\n\nAltersgruppe: Erwachsene";
            if (BTSenioren.Checked)                             //Abfrage nach der Altersgruppe Senioren
                output += "\n\nAltersgruppe: Senioren";
            MessageBox.Show(output.Substring(2));               //Substring um das erste ", " zu entfernen
        }
    }
}
