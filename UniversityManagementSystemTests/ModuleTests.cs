using UniversityManagementSystem.Entities;
using UniversityManagementSystem.Exceptions;
using UniversityManagementSystem.Service;
using UniversityManagementSystem.ValueObjects;

namespace UniversityManagementSystemTests
{
    public class ModuleTests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Check_If_Module_Id_Invalid_Exception_Is_Thrown()
        {
            Assert.Throws<ModuleIdInvalidException>(() => new Module(new ModuleId(0), "Sample test"));
        }
    }
}