using System;
using System.ComponentModel;
using System.Timers;
using System.Windows.Forms;

namespace _2021_01_14_Homes {
    public partial class Form1 : Form {

        System.Timers.Timer timer = new System.Timers.Timer();

        public Form1() {
            InitializeComponent();
            this.FormClosing += close;
            timer.Elapsed += timerElapsed;
            timer.Interval = 1;
            timer.Start();
        }

        private byte r = 0,
                    g = 255,
                    b = 0,
                    state = 0;

        private void timerElapsed(object sender, ElapsedEventArgs e) {
            if(state == 0) {
                r++;
                if(r >= 255)
                    state++;
            } else if(state == 1) {
                g--;
                if(g <= 0)
                    state++;
            } else if(state == 2) {
                b++;
                if(b >= 255)
                    state++;
            } else if(state == 3) {
                r--;
                if(r <= 0)
                    state++;
            } else if(state == 4) {
                g++;
                if(g >= 255)
                    state++;
            } else if(state == 5) {
                b--;
                if(b <= 0)
                    state = 0;
            }
            try {
                Invoke(new Action(delegate () {
                    this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
                }));
            } catch(Exception) { }

        }

        private void close(object sender, FormClosingEventArgs e) {
            timer.Stop();
        }

        private void button1_Click(object sender, EventArgs e) {
            int amount = (int)numericUpDown1.Value;

            int result = 0;
            for(int i = 0; i < amount; i++) {
                result += amount - (i + 1);
            }

            String output = "Es " + (result != 1 ? "werden " : "wird ") + result + " Leitung" + (result != 1 ? "en" : "") + " benötigt";
            MessageBox.Show(output, "", MessageBoxButtons.OK);
        }
    }
}
