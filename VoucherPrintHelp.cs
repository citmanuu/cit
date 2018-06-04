using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    public partial class VoucherPrintHelp : Form
    {
        List<VoucherPrint> objvoucherClass;
        int spendamount, currentspentamount, BECY;
        string DeptName, FKFYID, SL2, SL3;
        public VoucherPrintHelp(List<VoucherPrint> _objvoucherClass, int _spendamount,int _currentspentamount)
        {
            objvoucherClass = _objvoucherClass;
            spendamount = _spendamount;
            currentspentamount = _currentspentamount;

            foreach (var ObjvoucherClass in objvoucherClass)
            {
                DeptName = ObjvoucherClass.DeptName;
                BECY = ObjvoucherClass.BECY;
                FKFYID = ObjvoucherClass.FKFYID;
                SL2 = ObjvoucherClass.SL2;
                SL3 = ObjvoucherClass.SL3;
            }

            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void VoucherPrintHelp_Load(object sender, EventArgs e)
        {
            VoucherBindingSource.DataSource = objvoucherClass;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                //new Microsoft.Reporting.WinForms.ReportParameter("DeptName", objvoucherClass[0].DeptName.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("DeptName", DeptName),
                new Microsoft.Reporting.WinForms.ReportParameter("BECY", BECY.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("SL2Name", SL2),
                new Microsoft.Reporting.WinForms.ReportParameter("SL3Name", SL3),
                new Microsoft.Reporting.WinForms.ReportParameter("FKFYID", FKFYID),
                new Microsoft.Reporting.WinForms.ReportParameter("Amount", spendamount.ToString()),

            };
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.RefreshReport();

        }
    }
}
