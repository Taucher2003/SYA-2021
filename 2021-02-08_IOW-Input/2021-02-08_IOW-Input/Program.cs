﻿using System;
using System.Windows.Forms;

namespace _2021_02_08_IOW_Input {
    static class Program {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IowInput());
        }
    }
}
