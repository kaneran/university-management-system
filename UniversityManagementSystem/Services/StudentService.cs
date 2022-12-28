using UniversityManagementSystem.Entities;
using UniversityManagementSystem.Exceptions;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Service
{
    public class StudentService
    {
        private List<Student> _students;
        private ModuleService _moduleService;
        private Dictionary<string, ClassificationRange> _classificationMap;
        public StudentService()
        {
            _students = GetAllStudents();
            _moduleService = new ModuleService();
            _classificationMap = new Dictionary<string, ClassificationRange>()
            {
                {"fail", new ClassificationRange(0,39.9) },
                {"Third class (3rd)", new ClassificationRange(40,49.9) },
                {"Lower second class (2:2)", new ClassificationRange(50,59.9) },
                {"Upper second class (2:1)", new ClassificationRange(60,69.9) },
                {"First class", new ClassificationRange(70,100) }
            };
        }

        public bool CheckIfRetakesRequired(string studentName)
        {
            var student = GetStudent(studentName);
            var scores = _moduleService.GetScoresForCurrentYear(student);
            var retakeRequired = CheckIfRetakeRequired(scores);
            return retakeRequired;
        }

        public FinalGrade GetFinalGrade(string studentName)
        {
            var student = GetStudent(studentName);
            var scores = _moduleService.GetAllModuleGrades(student);
            var retakeRequired = CheckIfRetakeRequired(scores);
            if (retakeRequired)
            {
                throw new StudentHasntCompletedAllModulesException();
            }
            else
            {
                var averageScore = Math.Round(scores.Average(), 1);
                var classificationAchieved = _classificationMap.Where(c => averageScore >= c.Value.MinGrade && averageScore <= c.Value.MaxGrade).Select(c => c.Key).SingleOrDefault();
                return new FinalGrade(averageScore, classificationAchieved);
            }
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>() { new Student(1, "John Doe", "11/12/87"), new Student(2, "Justin Foley", "01/23/91") };
            return students;
        }

        public Student GetStudent(string studentName) => _students.SingleOrDefault(s => s.FullName == studentName);

        public bool CheckIfRetakeRequired(IEnumerable<int> scores) => scores.Where(score => score >= 40).Count() != scores.Count();
    }
}