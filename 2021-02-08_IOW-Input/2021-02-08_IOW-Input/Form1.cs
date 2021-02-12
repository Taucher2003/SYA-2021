using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _2021_02_08_IOW_Input {
    public partial class Form1 : Form {
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

        public Form1() {
            InitializeComponent();
            FormClosed += OnClose;
            OpenWarrior();
            _timer.Interval = 50;
            _timer.AutoReset = true;
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
        }

        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitOpenDevice();

        [DllImport("iowkit", SetLastError = true)]
        public static extern void IowKitCloseDevice(int iowHandle);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetNumDevs();

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitGetDeviceHandle(int numDevice);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitWrite(int iowHandle, int numPipe, ref byte buffer, int length);

        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitReadNonBlocking(int iowHandle, int numPipe, ref byte buffer, int length);

        private const byte Pin15 = 1 << 5;
        private const byte Pin16 = 1 << 6;
        private const byte Pin17 = 1 << 7;
        private const byte PinAllInput = Pin15 | Pin16 | Pin17;

        private void OpenWarrior() {
            IowKitOpenDevice();
            for (var i = 1; i <= IowKitGetNumDevs(); i++) {
                Handle = IowKitGetDeviceHandle(i);
            }
        }

        private readonly byte[] _data = new byte[5];

        private void InitializeWarriorStates(object sender, EventArgs e) {
            _data[0] = 0;
            _data[1] = PinAllInput;
            _data[2] = 0;
            _data[3] = 0;
            IowKitWrite(Handle, 0, ref _data[0], 5);
        }


        private void OnClick(int button, bool active) {
            var panel = button == 5
                ? panelPin15
                : button == 6
                    ? panelPin16
                    : panelPin17;
            panel.BackColor = active ? Color.DarkGreen : Color.DarkRed;
            UpdateLabel();
        }

        private void UpdateLabel() {
            labelCurrentInput.Invoke(new Action(() => {
                labelCurrentInput.Text = $@"_buffer[1] =  {_buffer[1]:X2}  ( " + _buffer[1] + @" ) ";
            }));
        }

        private void OnClose(object sender, FormClosedEventArgs e) {
            _timer.Stop();

            foreach (var handle in _handles) {
                IowKitCloseDevice(handle);
            }
        }

        private byte[] _buffer;
        private byte _currentPressed = PinAllInput;

        private void OnTimerElapsed(object sender, ElapsedEventArgs e) {
            if (_buffer is null) {
                _buffer = _data;
                UpdateLabel();
            }

            IowKitReadNonBlocking(Handle, 0, ref _buffer[0], 5);

            CheckEventCall(5, Pin15);
            CheckEventCall(6, Pin16);
            CheckEventCall(7, Pin17);

            _currentPressed = _buffer[1];
        }

        private void CheckEventCall(int button, byte pin) {
            if (((_currentPressed & pin) == 0) ^ ((_buffer[1] & pin) == 0)) {
                OnClick(button, (_buffer[1] & pin) == 0);
            }
        }
    }
}