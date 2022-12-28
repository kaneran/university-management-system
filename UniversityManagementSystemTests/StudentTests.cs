using UniversityManagementSystem.Exceptions;
using UniversityManagementSystem.Service;

namespace UniversityManagementSystemTests
{
    public class StudentTests
    {
        private StudentService _studentService;
        [SetUp]
        public void Setup()
        {
            _studentService = new StudentService();
        }

        [Test]
        [TestCase("John Doe", false)]
        [TestCase("Justin Foley", true)]
        public void Check_If_User_Has_To_Retake_Modules(string studentName, bool retakeRequired)
        {
            var result = _studentService.CheckIfRetakesRequired(studentName);
            Assert.That(result,Is.EqualTo(retakeRequired));
        }

        [Test]
        public void Get_Final_Grade_For_Course()
        {
            var studentName = "John Doe";
            var finalGrade = _studentService.GetFinalGrade(studentName);
            Assert.AreEqual(finalGrade.FinalScore, 89.7);
            Assert.AreEqual(finalGrade.FinalClassification, "First class");
        }

        [Test]
        public void Check_Modules_Not_Completed_Exception_IsThrown()
        {
            var studentName = "Justin Foley";
            Assert.Throws<StudentHasntCompletedAllModulesException>(() => _studentService.GetFinalGrade(studentName));
        }
    }
}