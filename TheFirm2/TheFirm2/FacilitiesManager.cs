using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class FacilitiesManager: AdministrativeAssistant
    {
        private bool _keyToFacility;

        public bool KeyToFacility
        {
            get { return _keyToFacility; }
            set { _keyToFacility = value; }
        }
    }
}
