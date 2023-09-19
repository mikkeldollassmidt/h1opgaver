using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class CFO: CTO
    {
        private bool _topLevel3;

        public bool TopLevel5
        {
            get { return _topLevel3; }
            set { _topLevel3 = value; }
        }
    }
}
