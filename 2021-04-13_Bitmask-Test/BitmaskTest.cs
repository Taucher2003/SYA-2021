using System;
using System.Windows.Forms;

namespace _2021_04_13_Bitmask_Test {
    public partial class BitmaskTest : Form {
        public BitmaskTest() {
            InitializeComponent();
            input1.TextChanged += Trigger;
            input2.TextChanged += Trigger;
            logicAnd.CheckedChanged += Trigger;
            logicOr.CheckedChanged += Trigger;

            input1.KeyPress += KeyCheck;
            input2.KeyPress += KeyCheck;
        }

        private int Calculate() {
            var firstInput = Convert.ToInt32(input1.Text, 2);
            var secondInput = Convert.ToInt32(input2.Text, 2);

            int result;

            if (logicOr.Checked)
                result = firstInput | secondInput;
            else
                result = firstInput & secondInput;

            return result;
        }

        private void Update() {
            try {
                var result = Calculate();
                output.Text = Convert.ToString(result, 2);
            } catch (FormatException) {
                // ReSharper disable once LocalizableElement
                output.Text = "Could not parse input values";
            } catch (ArgumentOutOfRangeException) {
                // ReSharper disable once LocalizableElement
                output.Text = "One input value is missing";
            }
        }

        private void Trigger(object sender, EventArgs args) {
            Update();
        }

        private void KeyCheck(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && e.KeyChar != '1' && e.KeyChar != '0') {
                e.Handled = true;
            }
        }
    }
}