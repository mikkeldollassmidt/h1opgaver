using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class COO: CFO
    {
        private bool _topLevel2;

        public bool TopLevel2
        {
            get { return _topLevel2; }
            set { _topLevel2 = value; }
        }
    }
}
