using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
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
            // Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MDIParent(0,0,0));
               //Application.Run(new Home());
             //Application.Run(new Home());
            Application.Run(new ImportExport());
        }
    }
}
