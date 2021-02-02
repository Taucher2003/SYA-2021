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
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i <= 20; i++) {
                if(i % 2 == 0) {
                    sb.AppendLine(i + "");
                }
            }
            MessageBox.Show(sb.ToString());
        }

        private void Button2_Click(object sender, EventArgs e) {
            int input = (int) numericUpDown2.Value;
            StringBuilder sb = new StringBuilder();
            for(int i = input; i >= 0; i--) {
                sb.AppendLine(i + "");
            }
            MessageBox.Show(sb.ToString());
        }

        private void Button3_Click(object sender, EventArgs e) {
            int input = (int)numericUpDown3.Value;
            int result = 0;
            for(int i = input; i>0; i--) {
                result += i;
            }
            MessageBox.Show(result + "");
        }

        private void Button4_Click(object sender, EventArgs e) {
            int input = (int)numericUpDown4.Value;
            int result = 1;
            for(int i = input; i > 0; i--) {
                result *= i;
            }
            MessageBox.Show(result + "");
        }

        private void Button5_Click(object sender, EventArgs e) {
            decimal input = numericUpDown5.Value;
            int years = 0;
            while(input < 1000000) {
                years++;
                input += input * ((Decimal) 0.1);
            }
            MessageBox.Show(years + " Jahre");
        }

        private void Button6_Click(object sender, EventArgs e) {
            new Form2().Show();
        }

        private void Button7_Click(object sender, EventArgs e) {
            int input = (int)numericUpDown7.Value;
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i<=input; i++) {
                if(input % i == 0) {
                    sb.Append(", " + i);
                }
            }
            MessageBox.Show(input + " ist teilbar durch: " + sb.ToString().Substring(2));
        }

        private void Button8_Click(object sender, EventArgs e) {
            int input = (int)numericUpDown8.Value;
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <= input; i++) {
                Boolean isPrim = (i != 0 && i != 1 && i % 2 != 0) || i == 2;
                int bounds = (int)Math.Floor(Math.Sqrt(i));
                for(int j = 3; j<=bounds; j += 2) {
                    if(i % j == 0) {
                        isPrim = false;
                    }
                }
                if(isPrim) {
                    sb.Append(", " + i);
                }
            }
            try {
                MessageBox.Show("Primzahlen bis " + input + ": " + sb.ToString().Substring(2));
            } catch(ArgumentOutOfRangeException) {
                MessageBox.Show("Keine Primzahlen gefunden");
            }
        }

        private void Button9_Click(object sender, EventArgs e) {
            String result = "";
            for(int i = 0; i < 4; i++) {
                for(int j = 0; j<(7-i); j++) {
                    result += j < i ? " " : "*";
                }
                result += "\n";
            }
            label1.Text = result;
            MessageBox.Show(result);
        }

        private void Button10_Click(object sender, EventArgs e) {
            decimal first = 2;
            decimal second = 1;
            decimal result = 1;
            Boolean incrementFirst = false;
            for(int i = 0; i<(int)numericUpDown10.Value; i++) {
                result *= first / second;
                if(incrementFirst) first += 2;
                else second += 2;
                incrementFirst = !incrementFirst;
            }
            MessageBox.Show(result*2 + "");
        }
    }
}
