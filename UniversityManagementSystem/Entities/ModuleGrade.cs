using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Entities
{
    public class ModuleGrade
    {
        public int ModuleId { get; }
        public int Score { get; }
        public int YearAtUni { get; }
        public ModuleGrade(int moduleId, int score, int yearAtUni)
        {
            ModuleId = moduleId;
            Score = score;
            YearAtUni = yearAtUni;
        }
    }
}
