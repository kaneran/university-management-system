using UniversityManagementSystem.Entities;
using UniversityManagementSystem.Services;

namespace UniversityManagementSystem.Service
{
    public class StudentService
    {
        private List<Student> _students;
        private ModuleService _moduleService;
        public StudentService()
        {
            _students = GetAllStudents();
            _moduleService = new ModuleService();
        }

        public bool CheckIfRetakesRequired(string studentName)
        {
            var student = _students.Where(s => s.FullName == studentName).SingleOrDefault();
            var scores = _moduleService.GetScoresForCurrentYear(student);
            return studentName == "John Doe";
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>() { new Student(1, "John Doe", "11/12/87"), new Student(2, "Justin Foley", "01/23/91") };
            return students;
        }
    }
}