using System;
using System.Timers;
using System.Windows.Forms;

namespace _2021_02_02_Timer {
    public partial class Timer : Form {
        private readonly System.Timers.Timer _timer = new System.Timers.Timer();
        private double _start;

        public Timer() {
            InitializeComponent();
            _timer.AutoReset = true;
            _timer.Interval = 1;
            _timer.Elapsed += TimerElapsed;
        }

        private void buttonStart_Click(object sender, EventArgs e) {
            _start = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds;
            _timer.Start();
            buttonStart.Text = "Reset";
        }

        private void buttonStop_Click(object sender, EventArgs e) {
            if (!_timer.Enabled) return;
            _timer.Stop();
            buttonStart.Text = "Reset + Start";
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e) {
            double millisDifference = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds - _start;
            String format = formatMillis(millisDifference);
            labelOutput.Invoke(new Action(delegate() { labelOutput.Text = format; }));
        }

        private String formatMillis(double millisDifference) {
            var millis = (long) millisDifference;
            var seconds = millis / 1000;
            var minutes = seconds / 60;

            millis %= 1000;
            seconds %= 60;

            var displaySeconds = (seconds < 10 ? "0" : "") + seconds;
            var displayMilliseconds = (millis < 10 ? "0" : "") + (millis < 100 ? "0" : "") + millis;

            var format = "";
            format += minutes + " Minute" + (minutes != 1 ? "n" : "") + ", ";
            format += displaySeconds + " Sekunde" + (seconds != 1 ? "n" : "") + ", ";
            format += displayMilliseconds + " Millisekunden";

            return format;
        }
    }
}