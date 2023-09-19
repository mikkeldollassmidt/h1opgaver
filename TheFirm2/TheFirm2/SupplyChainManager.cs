using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class SupplyChainManager: ContentWriter
    {
        private bool _hasSupplyChain;

        public bool HasSupplyChain
        {
            get { return _hasSupplyChain; }
            set { _hasSupplyChain = value; }
        }
    }
}
