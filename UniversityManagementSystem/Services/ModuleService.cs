using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Entities;
using UniversityManagementSystem.ValueObjects;

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
            var modules = new List<Module>() { new Module(new ModuleId(1), "Networks and Operating Systems"), new Module(new ModuleId(2), "Theory of Computation"), new Module(new ModuleId(3), "Final Year Project") };
            return modules;
        }

        public List<ModuleGrade> GetAllModuleGrades()
        {
            var moduleGrades = new List<ModuleGrade>() { new ModuleGrade(1, 1, 91, 2), new ModuleGrade(1, 2, 95, 2), new ModuleGrade(1, 3, 83, 3), new ModuleGrade(2, 3, 39, 3) };
            return moduleGrades;
        }
        public List<int> GetScoresForCurrentYear(Student student)
        {
            var scores = (from moduleGrade in _moduleGrades
                          where moduleGrade.StudentId == student.Id
                          select moduleGrade).ToDictionary(mg => mg.ModuleId, mg => new {score = mg.Score, yearAtUni = mg.YearAtUni});
            var currentYear = scores.Values.Select(value => value.yearAtUni).ToList().Max();
            var currentYearScores = scores.Values.Where(value => value.yearAtUni == currentYear).Select(value => value.score).ToList();
            return currentYearScores;
        }
    }
}
