using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class AdministrativeAssistant: Receptionist
    {
        private bool _accessToComputers;

        public bool AccessToComputers
        {
            get { return _accessToComputers; }
            set { _accessToComputers = value; }
        }
    }
}
