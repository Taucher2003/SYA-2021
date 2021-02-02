using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_09_17_Schleifen {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            decimal min = decimal.MaxValue;
            decimal max = 0;
            foreach(Control c in this.Controls) {
                if(c is NumericUpDown) {
                    max = Math.Max(max, ((NumericUpDown)c).Value);
                    min = Math.Min(min, ((NumericUpDown)c).Value);
                }
            }
            MessageBox.Show("Höchste Zahl: " + max + "\nKleinste Zahl: " + min);
        }
    }
}
