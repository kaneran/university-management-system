using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public class FinalGrade
    {
        public double FinalScore { get; set; }
        public string FinalClassification { get; set; }
        public FinalGrade(double finalScore, string finalClassification)
        {
            FinalScore = finalScore;
            FinalClassification = finalClassification;
        }
    }
}
