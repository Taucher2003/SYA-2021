using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace _2020_11_25_IOW_Identify {
    public partial class Form1 : Form {

        public int handle {
            get => handle_;
            set {
                handle_ = value;
                if(!handles.Contains(value))
                    handles.Add(value);
            }
        }

        private int handle_;
        private List<int> handles;

        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitOpenDevice();
        [DllImport("iowkit", SetLastError = true)]
        public static extern void IowKitCloseDevice(int iowHandle);
        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitGetNumDevs();
        [DllImport("iowkit", SetLastError = true)]
        public static extern int IowKitGetDeviceHandle(int numDevice);
        [DllImport("iowkit", SetLastError = true)]
        public static extern short IowKitGetProductId(int iowHandle);

        public Form1() {
            InitializeComponent();
            this.FormClosed += Form1_Closed;
            this.handles = new List<int>();
        }

        private void Button1_Click(object sender, EventArgs e) {
            //Öffne alle Warrior (max. 16)
            IowKitOpenDevice();
            //Speichere die Anzahl nach count
            int count = IowKitGetNumDevs();
            //Gebe die Anzahl der Warrior in label1 aus
            label1.Text = "Es " + (count == 1 ? "ist" : "sind") + " " + count + " IO-Warrior angeschlossen.";
            //Gehe alle Warrior durch
            for(int i = 1; i<=count; i++) {
                //Nehme den Handle des jeweiligen Warriors
                handle = IowKitGetDeviceHandle(i);
                //Lese die Produkt ID des Warriors mit der Handle aus
                short id = IowKitGetProductId(handle);
                //Füge den Warrior in den Text des Labels hinzu
                label1.Text += "\nEs ist ein " + getProductNameFromId(id) + " mit der ID: " + id + " angeschlossen";
            }
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e) {
            //Gehe alle angeschlossenen Warrior durch
            foreach(int handle in handles) {
                //Schließe den Warrior
                IowKitCloseDevice(handle);
            }
        }

        /// <summary>
        /// Gibt den Namen des Warriors entsprechend der Produkt ID zurück.
        /// </summary>
        /// <param name="id">Die Produkt ID, die überprüft werden soll</param>
        /// <returns>Den Namen des Produktes</returns>
        private String getProductNameFromId(short id) {
            switch (id) {
                case 5377:
                    return "IO-Warrior 24";
                case 5380:
                    return "IO-Warrior 28";
                case 5376:
                    return "IO-Warrior 40";
                case 5379:
                    return "IO-Warrior 56";
                default:
                    return null;
            }
        }
    }
}
