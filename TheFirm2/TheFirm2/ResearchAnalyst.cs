﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class ResearchAnalyst: FacilitiesManager
    {
        private bool _canResearch;

        public bool CanResearch
        {
            get { return _canResearch; }
            set { _canResearch = value; }
        }
    }
}
