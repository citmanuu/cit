using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
    class SL3Class
    {
        public string SL3Name
        {
            get;
            private set;
        }
        public int PKSL3
        {
            get;
            private set;
        }

        public SL3Class(int _PKSL3, string _SL3Name)
        {
            SL3Name = _SL3Name;
            PKSL3 = _PKSL3;
        }

    }
}
