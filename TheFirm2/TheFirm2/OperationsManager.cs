using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class OperationsManager: QualityAssuranceAnalyst
    {
        private bool _canOperate;

        public bool CanOperate  
        {
            get { return _canOperate; }
            set { _canOperate = value; }
        }
    }
}
