using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public class ClassificationRange
    {
        public double MinGrade { get; }
        public double MaxGrade { get; }
        public ClassificationRange(double minGrade, double maxGrade)
        {
            MinGrade = minGrade;
            MaxGrade = maxGrade;
        }
    }
}
