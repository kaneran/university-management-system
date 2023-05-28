using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public struct Student
    {
        public int Id { get; }
        public string FullName { get; }
        public string DOB { get; }
        public Student(int Id, string FullName, string DOB)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.DOB = DOB;
        }
    }
}
