using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Entities;

namespace UniversityManagementSystem.Services
{
    public class ModuleService
    {
        private List<Module> _modules;
        private List<ModuleGrade> _moduleGrades;
        public ModuleService()
        {
            _modules = GetAllModules();
            _moduleGrades = GetAllModuleGrades();
        }

        public List<Module> GetAllModules()
        {
            var modules = new List<Module>() { new Module(1, "Networks and Operating Systems"), new Module(2, "Theory of Computation"), new Module(3, "Final Year Project") };
            return modules;
        }

        public List<ModuleGrade> GetAllModuleGrades()
        {
            var moduleGrades = new List<ModuleGrade>() { new ModuleGrade(1, 1, 91, 2), new ModuleGrade(1, 2, 95, 2), new ModuleGrade(1, 3, 83, 3), new ModuleGrade(2, 3, 75, 3) };
            return moduleGrades;
        }
        public List<int> GetScoresForCurrentYear(Student student)
        {
            var scores = (from moduleGrades in _moduleGrades
                          where moduleGrades.StudentId == student.Id
                          select moduleGrades.Score).ToList();
            return scores;
        }
    }
}
