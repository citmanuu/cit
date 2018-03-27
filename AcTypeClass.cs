using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
    class AcTypeClass
    {
        public string AcTypeName { get; private set; }
        public int AcTypeId { get; private set; }
        public AcTypeClass(int _AcTypeId, string _AcTypeName)
        {
            AcTypeName = _AcTypeName; AcTypeId = _AcTypeId;
        }


    }
}
