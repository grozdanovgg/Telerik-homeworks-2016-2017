using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsProject
{
    class StudentTest
    {
        static void Main()
        {
            var studentList = new List<Student>();
            studentList.Add(new Student("Pesho", "Toshev", 17));
            studentList.Add(new Student("Gosho", "Yankov", 23));
            studentList.Add(new Student("Trosho", "Goshev", 32));
            studentList.Add(new Student("Mesho", "Kurtev", 14));
            studentList.Add(new Student("Ganka", "Penkova", 22));
            studentList.Add(new Student("Penka", "Genkova", 21));

            
            //Problem 3.First before last
            var firstNameBeforeLastList = Student.FirstNameBeforeLast(studentList);
            Console.WriteLine("This is the full list: ");
            Console.WriteLine(string.Join("\r\n", studentList));
            Console.WriteLine();

            Console.WriteLine("This is filtered list by First name before Last name lexi: ");
            Console.WriteLine(string.Join("\r\n", firstNameBeforeLastList));
            Console.WriteLine();

            //Problem 4. Age range
            //Write a LINQ query that finds the first name and last name 
            //of all students with age between 18 and 24.
            int startAge = 18;
            int endAge = 24;
            var ageBetweenList = Student.AgeBetween(studentList, startAge, endAge);
            Console.WriteLine($"Filtered list by age - between {startAge} and {endAge}: ");
            Console.WriteLine(string.Join("\r\n", ageBetweenList));
            Console.WriteLine();

            //Problem 5.
            //Using the extension methods OrderBy() and ThenBy() with lambda expressions
            //sort the students by first name and last name in descending order.
            //Order by and than by last name (sort the array using lampda)
            var sortedListOfStudents =
                studentList.OrderByDescending(student => student.FirstName)
                .ThenByDescending(x => x.LastName);

            //Order by First name and than by last name using LINQ
            var sortedListOfStudentsLINQ =
                from student in studentList
                orderby student.FirstName descending, student.LastName descending
                select student;

            Console.WriteLine("Sorted list by First name and Last name - descending: ");
            Console.WriteLine(string.Join("\r\n", sortedListOfStudentsLINQ));
            Console.WriteLine();


        }

    }
}
