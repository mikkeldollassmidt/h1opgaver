using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class CMO: HRManager
    {
            private bool _topLevel5;

            public bool TopLevel5
            {
                get { return _topLevel5; }
                set { _topLevel5 = value; }
            }
    }
}
