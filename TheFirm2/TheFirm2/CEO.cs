using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class CEO: COO
    {
        private bool _topLevel1;

        public bool TopLevel1
        {
            get { return _topLevel1; }
            set { _topLevel1 = value; }
        }
    }
}
