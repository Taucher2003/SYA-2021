using System;
using System.Windows.Forms;

namespace _2021_04_13_Bitmask_Test {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BitmaskTest());
        }
    }
}