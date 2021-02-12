using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2021_02_08_IOW_Input;

namespace _2021_02_12_IOW_Output {
    static class Program {

        internal static IowInput Input;
        
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Input = new IowInput();
            var _ = new IowOutput();
            Application.Run(Input);
        }
    }
}
