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
            //Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new MDIParent(1,0,0));
            //Application.Run(new frmHome());
            //Application.Run(new ImportExport());
            //Application.Run(new ImportHelp(1));
            //Application.Run(new frmBudget(1,0,0,null));
            //Application.Run(new frmBillDespatch(1,0,0,"admin1"));
            //Application.Run(new pdfsupports());
            //Application.Run(new frmVirtuaHead(1,0,0,null));
            //Application.Run(new EnableDisableHeads());
            //Application.Run(new frmAccount(0, 0, 0, null));
            //Application.Run(new Voucher_Generator());
            //Application.Run(new frmBudget(1,0,0,null));
            //Application.Run(new pdfsupports());
            Application.Run(new frmBillDespatchs(1, 0, 0, null));
        }
    }
}
