using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProjectManagement
{
    public class StudentManager
    {
        private List<Student> students;
        private int nextId;

        public StudentManager()
        {
            students = new List<Student>(); 
            nextId = 0;
        }

        public Student AddStudent(string name, int age)
        {
            var student = new Student
            {
                iId = nextId++,
                strName = name,
                iAge = age,
            };

            students.Add(student);
            return student;
        }

        public List<Student> GetStudents()
        {
            return new List<Student>(students);
        }
    }
}
