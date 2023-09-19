using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class ITSupportSpecialist: Accountant
    {
        private bool _canITSupport;

        public bool CanITSupport
        {
            get { return _canITSupport; }
            set { _canITSupport = value; }
        }
    }
}
