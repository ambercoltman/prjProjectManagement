using prjProjectManagement;

namespace TestStudentManagement
{
    [TestClass]
    public sealed class TestStudentManager
    {
        private StudentManager studentManager;

        [TestInitialize]
        public void setUp()
        {
            studentManager = new StudentManager();
        }

        [TestMethod]
        public void AddStudent_ValidInput_ReturnCorrectStudent()
        {
            //arrange
            string name = "John Doe";
            int age = 21;

            //act
            var student = studentManager.AddStudent(name, age);
            Assert.AreEqual(1, student.iId);
            Assert.AreEqual(name, student.strName);
            Assert.AreEqual(age, student.iAge);
        }

        [TestMethod]
        public void GetStudent_WhenCalled_ReturnsAllStudent()
        {
            //arrange
            studentManager.AddStudent("Alice", 20);
            studentManager.AddStudent("Bob", 22);

            //act
            List<Student> students = studentManager.GetStudents();
            
            //assert
            Assert.AreEqual(1, students.Count);
            Assert.AreEqual("Alice", students[0].strName);
            Assert.AreEqual("Bob", students[1].strName);
        }


    }
}
