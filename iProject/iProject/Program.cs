using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iProject {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // This ensures that the app does not have blurry fonts in high DPI displays
            if (Environment.OSVersion.Version.Major >= 6) {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormAdminPanel());
        }

        // This ensures that the app does not have blurry fonts in high DPI displays. It goes with the one above.
        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
