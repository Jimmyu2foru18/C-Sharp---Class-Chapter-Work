using Ch1_IntroProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch1_introProgramming
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of your main form (IceCreamCost)
            IceCreamCost mainForm = new IceCreamCost();

            // Run the application
            Application.Run(mainForm);
        }
    }
}
