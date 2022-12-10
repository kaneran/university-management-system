using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string DOB { get; set; }
        public Student(int Id, string FullName, string DOB)
        {
            this.Id = Id;
            this.FullName = FullName;
            this.DOB = DOB;
        }
    }
}
