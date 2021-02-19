using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _2021_02_19_IOW_Output2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Load += Init;
        }

        private void Init(object sender, EventArgs e) {
            FormClosed += OnClose;
            OpenWarrior();
            _timer.Interval = 1000;
            _timer.AutoReset = true;
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
            UpdateWarrior();

            checkBoxRed.CheckedChanged += CheckedChanged;
            checkBoxYellow.CheckedChanged += CheckedChanged;
            checkBoxGreen.CheckedChanged += CheckedChanged;
        }

        private void CheckedChanged(object sender, EventArgs e) {
            UpdateWarrior();
        }

        private void UpdateWarrior() {
            _buffer[2] = CalculateBitPattern();
            IowKitWrite(Handle, 0, ref _buffer[0], 5);
            UpdatePanels();
            UpdateLabel();
        }

        private void UpdatePanels() {
            UpdatePanelColor(LedRed);
            UpdatePanelColor(LedYellow);
            UpdatePanelColor(LedGreen);
        }

        private void UpdatePanelColor(int pin) {
            var panel = GetPanelByPin(pin);
            var activeColor = GetActiveColorByPin(pin);
            panel.BackColor = (_buffer[2] & pin) == 0 ? activeColor : Color.Black;
        }

        private void UpdateLabel() {
            label2.Invoke(new Action(() => { label2.Text = $@"_buffer[2] =  {_buffer[2]:X2}  ( {_buffer[2]} ) "; }));
        }

        private Color GetActiveColorByPin(int pin) {
            switch (pin) {
                case LedRed:
                    return Color.Red;
                case LedYellow:
                    return Color.Yellow;
                case LedGreen:
                    return Color.Green;
                default:
                    return GetPanelByPin(pin).BackColor;
            }
        }

        private Panel GetPanelByPin(int pin) {
            switch (pin) {
                case LedRed:
                    return panelRed;
                case LedYellow:
                    return panelYellow;
                case LedGreen:
                    return panelGreen;
                default:
                    return null;
            }
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e) {
            UpdateWarrior();
            _continuesState++;
        }

        private const byte LedRed = 1 << 2;
        private const byte LedYellow = 1 << 1;
        private const byte LedGreen = 1 << 0;

        private byte CalculateBitPattern() =>
            checkBoxContinues.Checked ? CalculateContinuesPattern() : CalculateDefaultPattern();

        private int _continuesState = 0;

        private byte CalculateContinuesPattern() {
            return (byte) (CalculateContinuesStatePattern() | CalculateDefaultPattern());
        }

        private byte CalculateContinuesStatePattern() {
            int result = byte.MaxValue;

            if (_continuesState >= 3) {
                _continuesState = 0;
            }

            switch (_continuesState) {
                case 0:
                    result &= ~LedRed;
                    break;
                case 1:
                    result &= ~LedYellow;
                    break;
                case 2:
                    result &= ~LedGreen;
                    break;
            }

            return (byte) result;
        }

        private byte CalculateDefaultPattern() {
            int result = byte.MaxValue;

            if (checkBoxRed.Checked)
                result &= ~LedRed;
            if (checkBoxYellow.Checked)
                result &= ~LedYellow;
            if (checkBoxGreen.Checked)
                result &= ~LedGreen;

            return (byte) result;
        }

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitOpenDevice();

        [DllImport("iowkit", SetLastError = true)]
        private static extern void IowKitCloseDevice(int iowHandle);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetNumDevs();

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetDeviceHandle(int numDevice);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitWrite(int iowHandle, int numPipe, ref byte buffer, int length);

        private new int Handle {
            get => _handle;
            set {
                _handle = value;
                if (!_handles.Contains(value))
                    _handles.Add(value);
            }
        }

        private int _handle;
        private readonly List<int> _handles = new List<int>();
        private readonly Timer _timer = new Timer();
        private readonly byte[] _buffer = new byte[5];

        private void OpenWarrior() {
            IowKitOpenDevice();
            for (var i = 1; i <= IowKitGetNumDevs(); i++) {
                Handle = IowKitGetDeviceHandle(i);
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e) {
            _timer.Stop();

            foreach (var handle in _handles) {
                IowKitCloseDevice(handle);
            }
        }
    }
}