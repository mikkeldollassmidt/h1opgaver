using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class DataAnalyst: OperationsManager
    {
        private bool _canAnylizeData;

        public bool CanAnylizeData
        {
            get { return _canAnylizeData; }
            set { _canAnylizeData = value; }
        }
    }
}
