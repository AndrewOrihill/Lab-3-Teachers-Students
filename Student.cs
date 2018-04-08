using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructorAndStudentAssignment
{
    class Student
    {
        private string Name;
        private int Grade;
        private Instructor Teacher;

        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Grade = 0;
        }

        public void SetGrade(int grade)
        {
            this.Grade = grade;
        }

        public void Print()
        {
            Console.WriteLine("I am a student called " + this.Name + " with a grade of " + this.Grade + ".");
            this.Teacher.Print();
        }
    }
}

