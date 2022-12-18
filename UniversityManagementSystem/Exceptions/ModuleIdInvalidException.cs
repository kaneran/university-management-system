using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Exceptions
{
    public class ModuleIdInvalidException : UniversityManagementSystemException
    {
        public ModuleIdInvalidException() : base("Invalid module id")
        {
        }
    }
}
