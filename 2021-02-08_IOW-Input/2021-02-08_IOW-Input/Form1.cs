using System;
using System.Timers;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace _2021_02_08_IOW_Input {
    public partial class Form1 : Form {
        private new int Handle {
            get => _handle;
            set {
                _handle = value;
                if(!_handles.Contains(value))
                    _handles.Add(value);
            }
        }

        private int _handle;
        private readonly List<int> _handles = new List<int>();

        private readonly Timer _timer = new Timer();
        
        public Form1() {
            InitializeComponent();
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
        private static extern int IowKitWrite(int iowHandle, int numPipe, ref byte[] buffer, int length);

        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitReadNonBlocking(int iowHandle, int numPipe, ref byte[] buffer, int length);

        private void OpenWarrior() {
            for (var i = 1; i <= IowKitGetNumDevs(); i++) {
                Handle = IowKitGetDeviceHandle(i);
            }
        }
        
        private void InitializeWarriorStates(object sender, EventArgs e) {
            var data = new byte[5];
            data[0] = 0;
            data[1] = 1 << 5 | 1 << 6 | 1 << 7;
            data[2] = 0;
            data[3] = 0;
            data[4] = 0;
            var writtenBytes = IowKitWrite(Handle, 0, ref data, 5);
            Console.WriteLine(writtenBytes);
        }

        private void OnClick(int button, bool active) {
            
        }

        private void OnClose(object sender, FormClosedEventArgs e) {
            foreach (var handle in _handles) {
                IowKitCloseDevice(handle);
            }
            _timer.Stop();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e) {
            var buffer = new byte[5];
            IowKitReadNonBlocking(Handle, 0, ref buffer, 5);
            Console.WriteLine(string.Join(" ", buffer));
        }
    }
}
