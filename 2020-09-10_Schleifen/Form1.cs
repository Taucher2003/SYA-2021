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

namespace _2020_09_10_Schleifen {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void ButtonQuit_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void ButtonHeadLoop_Click(object sender, EventArgs e) {
            if(checkBox1.Checked) {
                int i = 0;
                while(i <= 10) {
                    listBox1.Items.Add(++i);
                }
            } else {
                String abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for(int j = 0; j < abc.Length; j++) {
                    listBox1.Items.Add(abc.ElementAt(j));
                }
            }

        }

        private void ButtonFootLoop_Click(object sender, EventArgs e) {
            if(checkBox1.Checked) {
                int i = 0;
                do {
                    listBox1.Items.Add(i++);
                } while(i <= 10);
            } else {
                String abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int j = 0;
                do {
                    listBox1.Items.Add(abc.ElementAt(j++));
                } while(j < abc.Length);
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
        }

        private void ButtonAllLoops_Click(object sender, EventArgs e) {
            if(checkBox1.Checked) {
                for(int i = 0; i < 10; i++) {
                    listBox1.Items.Add(i);
                }
                listBox1.Items.Add("---");
                int j = 0;
                while(j < 10) {
                    listBox1.Items.Add(j++);
                }
                listBox1.Items.Add("---");
                j = 0;
                do {
                    listBox1.Items.Add(j++);
                } while(j < 10);
            } else {
















                String abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


                //for(int i = 0; i<abc.Length; i++) {
                  //  listBox1.Items.Add(abc.ElementAt(i));
                //}






































                foreach(char c in abc.ToCharArray()) {
                    listBox1.Items.Add(c);
                }






































                int j = 0;
                while(j < abc.Length) {
                    listBox1.Items.Add(abc.ElementAt(j++));
                }





































                j = 0;
                do {
                    listBox1.Items.Add(abc.ElementAt(j++));
                } while(j < abc.Length);
















            }
        }
    }
}
