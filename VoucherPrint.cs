using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
    public class VoucherPrint
    {
        public string DeptName { get; set; }
        public int BECY { get; set; }
        public string SL2 { get; set; }
        public string SL3 { get; set; }
        public string FKFYID { get; set; }


        public VoucherPrint(string _DeptName, int _BECY, string _SL2, string _SL3, string _FKFYID)
        {
            DeptName = _DeptName;
            BECY = _BECY;
            SL2 = _SL2;
            SL3 = _SL3;
            FKFYID = _FKFYID;
        }
    }       
}
