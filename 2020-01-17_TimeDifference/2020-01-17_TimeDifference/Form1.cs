using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_01_17_TimeDifference {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            int secondsOne = inputToSeconds((int)hour1.Value, (int)minute1.Value, (int)second1.Value);
            int secondsTwo = inputToSeconds((int)hour2.Value, (int)minute2.Value, (int)second2.Value);

            int result = secondsOne - secondsTwo;

            int hourOut, minuteOut, secondOut;
            secondsToOutput(result, out hourOut, out minuteOut, out secondOut);

            hoursOut.Text = hourOut + "";
            minutesOut.Text = minuteOut + "";
            secondsOut.Text = secondOut + "";
        }

        private int inputToSeconds(int hours, int minutes, int seconds) {
            return (((hours * 60) + minutes) * 60) + seconds;
        }

        private void secondsToOutput(int seconds, out int hour, out int minute, out int second) {
            int minutes = seconds / 60;
            int hours = minutes / 60;
            second = seconds % 60;
            hour = hours;
            minute = minutes % 60;
        }
    }
}
