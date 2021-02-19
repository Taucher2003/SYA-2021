using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _2021_02_08_IOW_Input {
    public partial class IowInput : Form {
        public IowInput() {
            InitializeComponent();
            Init();
        }

        private void Init() {
            FormClosed += OnClose;
            OpenWarrior();
            _timer.Interval = 50;
            _timer.AutoReset = true;
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
            ClickActions += OnClick;
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
        public static extern int IowKitWrite(int iowHandle, int numPipe, ref byte buffer, int length);

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitReadNonBlocking(int iowHandle, int numPipe, ref byte buffer, int length);

        public const byte Pin15 = 1 << 5;
        public const byte Pin16 = 1 << 6;
        public const byte Pin17 = 1 << 7;
        public const byte PinAllInput = Pin15 | Pin16 | Pin17;

        private const byte PinAllOutput = 1 << 0 | 1 << 1 | 1 << 2;

        public new int Handle {
            get => _handle;
            private set {
                _handle = value;
                if (!_handles.Contains(value))
                    _handles.Add(value);
            }
        }

        public event ClickHandler ClickActions {
            add => _clickHandler += value;
            remove => _clickHandler -= value;
        }

        public delegate void ClickHandler(byte pin, bool active);

        private ClickHandler _clickHandler;

        private int _handle;
        private readonly List<int> _handles = new List<int>();
        private readonly Timer _timer = new Timer();

        private void OpenWarrior() {
            IowKitOpenDevice();
            for (var i = 1; i <= IowKitGetNumDevs(); i++) {
                Handle = IowKitGetDeviceHandle(i);
            }
        }

        private readonly byte[] _buffer = new byte[5];

        private void InitializeWarriorStates(object sender, EventArgs e) {
            _buffer[0] = 0;
            _buffer[1] = PinAllInput;
            _buffer[2] = PinAllOutput;
            _buffer[3] = 0;
            IowKitWrite(Handle, 0, ref _buffer[0], 5);
        }

        private void OnClick(byte pin, bool active) {
            var panel = GetPanelByPin(pin);
            panel.BackColor = active ? Color.DarkGreen : Color.DarkRed;
            UpdateLabel();
        }

        private Panel GetPanelByPin(byte pin) {
            switch (pin) {
                case Pin15:
                    return panelPin15;
                case Pin16:
                    return panelPin16;
                case Pin17:
                    return panelPin17;
                default:
                    return null;
            }
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

        private byte _currentPressed = PinAllInput;

        private void OnTimerElapsed(object sender, ElapsedEventArgs e) {
            IowKitReadNonBlocking(Handle, 0, ref _buffer[0], 5);
            Console.WriteLine(string.Join(" ", _buffer));

            CheckEventCall(Pin15);
            CheckEventCall(Pin16);
            CheckEventCall(Pin17);

            _currentPressed = _buffer[1];
        }

        private void CheckEventCall(byte pin) {
            if (((_currentPressed & pin) == 0) ^ ((_buffer[1] & pin) == 0)) {
                _clickHandler(pin, (_buffer[1] & pin) == 0);
            }
        }

        public byte[] GetBuffer() {
            return _buffer;
        }
    }
}