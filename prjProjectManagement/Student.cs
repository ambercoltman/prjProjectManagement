using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prjProjectManagement
{
    public class Student
    {
        public int iId { get; set; }
        public string strName { get; set; }
        public int iAge { get; set; }

        public override string ToString()
        {
            return $"ID: {iId}, Name: {strName}, Age: {iAge}";
        }
    }
}
