using System.Collections.Generic;
using System.Runtime.InteropServices;
using _2021_02_08_IOW_Input;

// ReSharper disable LocalizableElement

namespace _2021_02_12_IOW_Output {
    public class IowOutput {
        private const byte Pin17Shift = 0;
        private const byte Pin18Shift = 1;
        private const byte Pin19Shift = 2;

        public const byte Pin17 = 1 << Pin17Shift;
        public const byte Pin18 = 1 << Pin18Shift;
        public const byte Pin19 = 1 << Pin19Shift;

        public const byte PinAllOutput = Pin17 | Pin18 | Pin19;

        [DllImport("iowkit", SetLastError = true)]
        private static extern int IowKitWrite(int iowHandle, int numPipe, ref byte buffer, int length);

        private readonly Dictionary<byte, byte> _inputPinToOutputPinShift = new Dictionary<byte, byte> {
            {IowInput.Pin15, Pin17Shift},
            {IowInput.Pin16, Pin18Shift},
            {IowInput.Pin17, Pin19Shift}
        };

        public IowOutput() => Program.Input.ClickActions += OnButtonClick;

        private void OnButtonClick(byte pin, bool active) {
            var change = _inputPinToOutputPinShift[pin];
            SetBufferByte(2, change, active);
            var buffer = Program.Input.GetBuffer();
            WriteToIow(new []{ buffer[0], IowInput.PinAllInput, buffer[2], buffer[3], buffer[4] });
        }

        private static void WriteToIow(byte[] data) {
            IowKitWrite(Program.Input.Handle, 0, ref data[0], 5);
        }

        private static void SetBufferByte(int bufferIndex, int bitPosition, bool active) {
            var current = Program.Input.GetBuffer()[bufferIndex];
            int targetState;
            
            if (active) {
                targetState = current & ~(1 << bitPosition);
            } else {
                targetState = current | 1 << bitPosition;
            }
            
            Program.Input.GetBuffer()[bufferIndex] = (byte)targetState;
        }
    }
}
