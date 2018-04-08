using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructorAndStudentAssignment
{
    class Instructor
    {
        private string Name;
        private string Coursename;

        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.Coursename = courseName;
}

            public void SetStudentGrade(Student student, int grade)
        {
            student.SetGrade(grade);
        }

        public void Print()
        {
            Console.WriteLine("I am " + this.Name + ", a teacher of the course " + this.Coursename + " who gave that student's grade.\n");
        }
    }
}
