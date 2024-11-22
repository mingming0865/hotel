using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI());
        }
    }
}
