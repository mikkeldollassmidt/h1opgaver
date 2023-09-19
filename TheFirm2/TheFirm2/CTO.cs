using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class CTO: CMO
    {
        private bool _topLevel4;

        public bool TopLevel4
        {
            get { return _topLevel4; }
            set { _topLevel4 = value; }
        }
    }
}
