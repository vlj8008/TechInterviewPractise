using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TechInterviewPractise
{

    class Student
    {
       public string FirstName;
       public string LastName;
       public int StudentId;
       public int GradePointAverage;

        public string FormatFullName()
        {
            return FirstName + "  " + LastName;
        }

        //base (built-in contructor)

        public Student()
        {
            
        }

        //specific constructor if you know GPA

        public Student(int gpa)
        {
            
            GradePointAverage=gpa;

        }

        //specific constructor if you know first and last name

        public Student(string firstName, string lastName)
        {
            
            FirstName = firstName;
            LastName = lastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // using base constructor

            Student student1 = new Student();
            student1.FirstName = "Josy";
            student1.LastName = "Jones";
            
            string diplayName = student1.FormatFullName();

            Console.WriteLine("Hello, my name is " + diplayName);
            Console.WriteLine("My GPA is " + student1.GradePointAverage);
            Console.WriteLine("My student ID is " + student1.StudentId);

            // using student constructor with gpa

            int GradePointAverage = 3;
            
            Student student2 = new Student(GradePointAverage);
            student2.FirstName = "Vicky";
            student2.LastName = "Jones";
            student2.StudentId = 1;
            
            Console.WriteLine(" Your GPA is " + student2.GradePointAverage);
            Console.WriteLine("Your ID is " + student2.StudentId);
            Console.ReadLine();

        }
    }
}
