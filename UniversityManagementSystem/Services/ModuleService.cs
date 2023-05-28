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
        private IReadOnlyDictionary<int, List<ModuleGrade>> _moduleGrades;
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

        public IReadOnlyDictionary<int,List<ModuleGrade>> GetAllModuleGrades()
        {
            IReadOnlyDictionary<int, List<ModuleGrade>> moduleGrades = new Dictionary<int, List<ModuleGrade>>()
            {
                { 1, new List<ModuleGrade>(){
                    new ModuleGrade(1, 91, 2), new ModuleGrade(2, 95, 2), new ModuleGrade(3, 83, 3)
                } },
                { 2, new List<ModuleGrade>(){
                    new ModuleGrade(3, 39, 3)
                } }
            };
            return moduleGrades;
        }
        public List<int> GetScoresForCurrentYear(Student student)
        {
            var allModuleGradesForStudent = _moduleGrades[student.Id];
            var moduleGrades = (from moduleGrade in allModuleGradesForStudent
                          select new {moduleId= moduleGrade.ModuleId, score= moduleGrade.Score, yearAtUni= moduleGrade.YearAtUni});
            var currentYear = moduleGrades.Select(mg => mg.yearAtUni).Max();
            var currentYearScores = moduleGrades.Where(mg => mg.yearAtUni == currentYear).Select(mg => mg.score).ToList();
            return currentYearScores;
        }

        public IEnumerable<int> GetAllModuleGrades(Student student)
        {
            var moduleGrades = _moduleGrades[student.Id].Select(mg => mg.Score);
            return moduleGrades;

        }
    }
}
