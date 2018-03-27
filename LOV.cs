using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANUUFinance
{
    class LOV
    {
        public string ListItemDesc
        {
            get;
            private set;
        }

        public int ListItemID
        {
            get;
            private set;
        }

        public LOV(int _ListItemID, string _ListItemDesc)
        {
            ListItemDesc = _ListItemDesc;
            ListItemID = _ListItemID;
        }
    }
}
