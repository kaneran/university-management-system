using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public class ModuleGrade
    {
        public int StudentId { get; set; }
        public int ModuleId { get; set; }
        public int Score { get; set; }
        public int YearAtUni { get; set; }
        public ModuleGrade(int studentId, int moduleId, int score, int yearAtUni)
        {
            StudentId = studentId;
            ModuleId = moduleId;
            Score = score;
            YearAtUni = yearAtUni;
        }
    }
}
