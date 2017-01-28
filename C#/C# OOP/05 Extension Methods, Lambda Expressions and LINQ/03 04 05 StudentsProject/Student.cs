using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsProject
{
    public class Student
    {
        //fields
        private string firstName;
        private string lastName;
        private int age;

        //properties
        public string FirstName { get { return this.firstName; } }
        public string LastName { get { return this.lastName; } }

        //constructor
        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        //more methods
        public static List<Student> FirstNameBeforeLast(List<Student> studentList)
        {
            var result =
                from student in studentList
                where student.firstName.CompareTo(student.lastName) < 0
                select student;
            return result.ToList();
        }

        public static List<Student> AgeBetween(List<Student> studentList, int startAge, int endAge)
        {
            var result =
                from student in studentList
                where student.age >= startAge && student.age <= endAge
                select student;

            return result.ToList();
        }

        public override string ToString()
        {
            return String.Format("{0} {1} (age {2})", this.firstName, this.lastName, this.age);
        }

    }
}
