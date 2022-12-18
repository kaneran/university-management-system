using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Exceptions
{
    public abstract class UniversityManagementSystemException : Exception
    {
        protected UniversityManagementSystemException(string message) : base(message)
        {
        }
    }
}

