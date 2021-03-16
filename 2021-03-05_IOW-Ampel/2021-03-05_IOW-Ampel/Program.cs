using System;
using System.Windows.Forms;
using _2021_02_08_IOW_Input;

namespace _2021_03_05_IOW_Ampel {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IowAmpel(new IowInput(false)));
        }
    }
}