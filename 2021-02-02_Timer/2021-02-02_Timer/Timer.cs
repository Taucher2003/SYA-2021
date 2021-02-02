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

namespace _2021_02_02_Timer {
    public partial class Timer : Form {
        private System.Timers.Timer timer = new System.Timers.Timer();
        private double start;

        public Timer() {
            InitializeComponent();
            timer.AutoReset = true;
            timer.Interval = 1;
            timer.Elapsed += timerElapsed;
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            start = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            timer.Start();
            buttonStart.Text = "Reset";
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            if(timer.Enabled) {
                timer.Stop();
                buttonStart.Text = "Reset + Start";
            }
        }

        private void timerElapsed(object sender, ElapsedEventArgs e) {
            double millisDifference = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds - start;
            String format = formatMillis(millisDifference);
            labelOutput.Invoke(new Action(delegate () {
                labelOutput.Text = format;
            }));
        }

        private String formatMillis(double millisDifference) {

            long millis = (long) millisDifference;
            long seconds = millis / 1000;
            long minutes = seconds / 60;

            millis %= 1000;
            seconds %= 60;

            String displaySeconds = (seconds < 10 ? "0" : "") + seconds;
            String displayMilliseconds = (millis < 10 ? "0" : "") + (millis < 100 ? "0" : "") + millis;

            String format = "";
            format += minutes + " Minute" + (minutes != 1 ? "n" : "") + ", ";
            format += displaySeconds + " Sekunde" + (seconds != 1 ? "n" : "") + ", ";
            format += displayMilliseconds + " Millisekunden";

            return format;
        }
    }
}
