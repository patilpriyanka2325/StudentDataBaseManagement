using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataBaseManagement.Model
{
    internal class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }

        public Student(int roll, string name)
        {
            this.Rollno = roll;
            this.Name = name;
        }
    }
}
