using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm2
{
    internal class ProjectManager: ProductManager
    {
        private bool _canManageProjects;

        public bool CanManageProjects
        {
            get { return _canManageProjects; }
            set { _canManageProjects = value; }
        }
    }
}
