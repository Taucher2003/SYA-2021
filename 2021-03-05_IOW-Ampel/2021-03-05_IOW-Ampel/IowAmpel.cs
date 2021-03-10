using System;
using System.Timers;
using System.Windows.Forms;
using _2021_02_08_IOW_Input;
using Timer = System.Timers.Timer;

namespace _2021_03_05_IOW_Ampel {
    public partial class Form1 : Form {
        private readonly IowInput _input;
        private readonly Timer _timer = new Timer();

        private const byte LedRed = 1 << 2;
        private const byte LedYellow = 1 << 1;

        private const byte LedGreen = 1 << 0;

        public Form1(IowInput input) {
            _input = input;
            FormClosed += _input.OnClose;
            FormClosed += (o, args) => _timer.Stop();
            _input.ClickActions += OnClick;
            InitializeComponent();
            _timer.Interval = 1500;
            _timer.AutoReset = true;
            _timer.Elapsed += TimerOnElapsed;
            _timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e) {
            Invoke(new Action(() => { label1.Text = $@"Pattern: {_patternState} | State: {State}"; }));

            if (_patternState < 2) {
                Animation();
                return;
            }

            switch (State) {
                case 1:
                    State = 2;
                    break;
                case 3:
                    State = 0;
                    break;
            }
        }

        private void Animation() {
            var buffer = _input.GetBuffer();
            buffer[1] = IowInput.PinAllInput;
            int result;

            switch (State) {
                case 1:
                    State1Animation(out result);
                    break;
                case 3:
                    State3Animation(out result);
                    break;
                default:
                    return;
            }

            _patternState++;

            buffer[2] = (byte) result;
            WriteToIow(buffer);
        }

        private void State1Animation(out int result) {
            switch (_patternState) {
                case 0:
                    result = ~LedGreen;
                    return;
                case 1:
                    result = ~LedYellow;
                    return;
                case 2:
                    result = ~LedRed;
                    return;
            }

            result = 0;
        }

        private void State3Animation(out int result) {
            switch (_patternState) {
                case 0:
                    result = ~LedRed;
                    return;
                case 1:
                    result = ~(LedRed | LedYellow);
                    return;
                case 2:
                    result = ~LedGreen;
                    return;
            }

            result = 0;
        }

        /// <summary>
        /// 0 -> Cars have Green
        /// 1 -> Cars to Red
        /// 2 -> Cars have Red
        /// 3 -> Cars to Green
        /// </summary>
        private int State {
            get => _state;
            set {
                OnStateChange(value);
                _state = value;
                _patternState = 0;
            }
        }

        private void OnStateChange(int newState) {
            var buffer = _input.GetBuffer();
            buffer[1] = IowInput.PinAllInput;
            int result = buffer[2];

            switch (newState) {
                case 0:
                    result = ~LedGreen;
                    break;
                case 2:
                    result = ~LedRed;
                    break;
            }

            buffer[2] = (byte) result;
            WriteToIow(buffer);
        }

        private int _state;

        private int _patternState = 0;

        private void OnClick(byte pin, bool active) {
            switch (pin) {
                case IowInput.Pin15:
                case IowInput.Pin16:
                    ChangeState(1, 0);
                    break;
                case IowInput.Pin17:
                    ChangeState(3, 2);
                    break;
            }
        }

        private void ChangeState(int newState, int neededState) {
            Invoke(new Action(() => {
                label1.Text = $@"newState: {newState} | neededState: {neededState} | State: {State}";
            }));
            if (State == neededState) {
                State = newState;
            }
        }

        private void WriteToIow(byte[] data) {
            IowInput.IowKitWrite(_input.Handle, 0, ref data[0], 5);
        }
    }
}