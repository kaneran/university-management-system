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
        [TestCase("John Doe", true)]
        [TestCase("Justin Foley", false)]
        public void Check_If_User_Has_To_Retake_Modules(string studentName, bool retakeRequired)
        {
            var result = _studentService.CheckIfRetakesRequired(studentName);
            Assert.That(result,Is.EqualTo(retakeRequired));
        }
    }
}