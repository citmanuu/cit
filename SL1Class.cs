using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
    class SL1Class
    {
        public string SL1Name {
                                get;
                                private set;
                                }
        public int SL1ID {
                            get;
                            private set;
                         }

        public SL1Class (int _SL1ID, string _SL1Name)
        {
            SL1Name = _SL1Name;
            SL1ID = _SL1ID;
        }

    }
    }


