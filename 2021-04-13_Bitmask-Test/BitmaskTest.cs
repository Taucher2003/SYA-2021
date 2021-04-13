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
            } catch (FormatException) { } catch (ArgumentOutOfRangeException) { }
        }

        private void Trigger(object sender, EventArgs args) {
            Update();
        }
    }
}