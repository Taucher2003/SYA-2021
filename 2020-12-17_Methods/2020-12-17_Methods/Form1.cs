using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_12_17_Methods {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e) {
            label1.Text = multiply(double.Parse(textBox1.Text), double.Parse(textBox1.Text)) + "";
        }


        private void button2_Click(object sender, EventArgs e) {
            double result,
                number1 = double.Parse(textBox3.Text),
                number2 = double.Parse(textBox4.Text);
            switch(comboBox1.SelectedIndex) {
                case 0:
                    result = multiply(number1, number2);
                    break;
                default:
                    result = divide(number1, number2);
                    break;
            }
            label2.Text = result + "";
        }

        private void button3_Click(object sender, EventArgs e) {
            label3.Text = add(double.Parse(textBox5.Text), double.Parse(textBox6.Text)) + "";
            label4.Text = subtract(double.Parse(textBox5.Text), double.Parse(textBox6.Text)) + "";
            label5.Text = multiply(double.Parse(textBox5.Text), double.Parse(textBox6.Text)) + "";
            label6.Text = divide(double.Parse(textBox5.Text), double.Parse(textBox6.Text)) + "";
        }

        public double add(params double[] numbers) {
            checkArguments(numbers);
            double result = 0;
            foreach(double number in numbers) {
                result += number;
            }
            return result;
        }

        public double subtract(double first, params double[] numbers) {
            checkArguments(numbers);
            double result = first;
            foreach(double number in numbers) {
                result -= number;
            }
            return result;
        }

        public double multiply(params double[] numbers) {
            checkArguments(numbers);
            double result = 1;
            foreach(double number in numbers) {
                result *= number;
            }
            return result;
        }

        public double divide(double first, params double[] numbers) {
            checkArguments(numbers);
            double result = first;
            foreach(double number in numbers) {
                result /= number;
            }
            return result;
        }

        public void checkArguments(double[] numbers) {
            if(numbers.Length == 0) {
                throw new ArgumentException();
            }
        }
    }
}
