using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Exceptions
{
    public class StudentHasntCompletedAllModulesException : UniversityManagementSystemException
    {
        public StudentHasntCompletedAllModulesException() : base("Student hasn't completed all modules.")
        {

        }
    }
}
