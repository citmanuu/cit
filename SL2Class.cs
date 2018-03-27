using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
    class SL2Class
    {
        public string SL2Name
        {
            get;
            private set;
        }
        public int SL2ID
        {
            get;
            private set;
        }

        public SL2Class(int _SL2ID, string _SL2Name)
        {
            SL2Name = _SL2Name;
            SL2ID = _SL2ID;
        }

    }
}
