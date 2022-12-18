using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Exceptions;

namespace UniversityManagementSystem.ValueObjects
{
    public record ModuleId
    {
        public uint Value { get; }

        public ModuleId(uint value)
        {
            if(value == 0)
            {
                throw new ModuleIdInvalidException();
            }
            Value = value;
        }
    }
}
