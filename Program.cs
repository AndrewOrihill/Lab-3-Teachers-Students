using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructorAndStudentAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor John = new Instructor("John", "ENG1010");
            Instructor Mike = new Instructor("Mike", "MATH1410");

            Student Jane = new Student("Jane", John);
            Student Joe = new Student("Joe", John);

            Student Melissa = new Student("Melissa", Mike);
            Student Matt = new Student("Matt", Mike);
            //-------------------------------------------
            John.SetStudentGrade(Jane, 95);
            John.SetStudentGrade(Joe, 85);

            Mike.SetStudentGrade(Melissa, 90);
            Mike.SetStudentGrade(Matt, 92);

            Jane.Print();
            Joe.Print();
            Melissa.Print();
            Matt.Print();
        }
    }
}
