using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{

    class Student
    {
        //properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FacultyNumber { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public List<int> Marks { get; private set; }
        public int GroupNumber { get; private set; }

        //constructor
        public Student(string firstName, string lastName, string facultyNumber, 
            string tel, string email,List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
    }
}
