using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace _2020_08_20_Fragebogen {
    public partial class Fragebogen : Form {
        int i;
        int r;
        int g;
        int b;
        public Fragebogen() {
            InitializeComponent();
            i = 0;
            r = 0;
            g = 255;
            b = 0;
            System.Timers.Timer t = new System.Timers.Timer();
            t.AutoReset = true;
            t.Interval = 1;
            t.Elapsed += timer;
            t.Start();
        }

        public void timer(object sender, ElapsedEventArgs e) {
            try {
                this.Invoke(new Action(delegate () {
                    if (i == 0) {
                        r++;
                        if (r >= 255)
                            i++;
                    } else if (i == 1) {
                        g--;
                        if (g <= 0)
                            i++;
                    } else if (i == 2) {
                        b++;
                        if (b >= 255)
                            i++;
                    } else if (i == 3) {
                        r--;
                        if (r <= 0)
                            i++;
                    } else if (i == 4) {
                        g++;
                        if (g >= 255)
                            i++;
                    } else if (i == 5) {
                        b--;
                        if (b <= 0)
                            i = 0;
                    }
                    BackColor = Color.FromArgb(0xff, r, g, b);
                }));
            } catch (ObjectDisposedException) { }
        }

        private void Button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e) {
            String output = null;
            output = radioButton1.Checked ? "Männlich" : radioButton2.Checked ? "Weiblich" : "Keine Auswahl";

            if (checkBox1.Checked)
                output += ", C# Kenntnisse";
            if (checkBox2.Checked)
                output += ", C++ Kenntnisse";
            if (checkBox3.Checked)
                output += ", Java Kenntnisse";

            MessageBox.Show(output, "Auswertung", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
