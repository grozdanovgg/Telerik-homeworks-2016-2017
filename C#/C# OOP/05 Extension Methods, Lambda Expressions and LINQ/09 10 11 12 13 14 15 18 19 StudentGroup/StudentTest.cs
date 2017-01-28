using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    ////    Problem 9. Student groups

    //Select only the students that are from group number 2
    //Use LINQ query.Order the students by FirstName.
    class Program
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student("Dwayne", "Johnson", "132503", "064696011", "dwayne@abv.bg", new List<int>() { 2,2,1 }, 1),
                new Student("Vin", "Diesel", "122606", "0873669952", "diesel@gmail.com", new List<int>() { 3, 5, 3, 4 }, 2),
                new Student("Rosie", "Huntington-Whiteley", "206006", "026505543", "rose@abv.bg", new List<int>() { 2, 6}, 3),
                new Student("Jason", "Statham","504503", "027304441", "jason@hotmail.com", new List<int>() { 3, 5 }, 3),
                new Student("Megan", "Fox", "607506", "020256973", "m.fox@abv.bg", new List<int>() { 2, 4, 2 }, 2),
                new Student("Miranda", "Kerr","025011", "0888123321", "kerr@abv.bg", new List<int>() { 6, 5, 5, 4 }, 1),
                new Student("Leonardo", "DiCaprio", "054206", "064885203", "di@gmail.com", new List<int>() { 6 }, 2),
                new Student("Emma", "Watson", "321012", "021234567", "emma@abv.bg", new List<int>() { 6, 6, 6, 6, 6 }, 3),
                new Student("Kristen ", "Stewart", "124206", "0897030405", "stewart.kristen@abv.bg", new List<int>() { 5 }, 2),
                new Student("Selena ", "Gomez", "508205", "026547891", "sgomez@gmail.com", new List<int>() { 6, 5 }, 1),
                new Student("Miley", "Cyrus", "087006", "021346795", "miley@abv.bg", new List<int>() { 6 }, 2),
                new Student("Taylor", "Swift", "325510", "029764315", "swift@abv.bg", new List<int>() { 2, 2,3,4 }, 3),
            };


            var studentsFromGroupTwo =
                from student in listOfStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            Console.WriteLine("Students from group 2: ");
            foreach (var student in studentsFromGroupTwo)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.GroupNumber}");
            }
            Console.WriteLine();

            //Problem 10

            var studentsFromGroupTwoByExtensions =
                listOfStudents.Where(student => student.GroupNumber == 2)
                .OrderBy(student => student.FirstName);
            Console.WriteLine("Students from group 2: ");
            foreach (var student in studentsFromGroupTwoByExtensions)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.GroupNumber}");
            }
            Console.WriteLine();

            //Problem 11. Extract students by email
            Console.WriteLine("Students wit abv.bg emails: ");
            var studentsWitnABVMail =
                from student in listOfStudents
                where student.Email.EndsWith("abv.bg")
                select student;
            foreach (var student in studentsWitnABVMail)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Email}");
            }
            Console.WriteLine();

            //Problem 12. Extract students by phone
            var studentsWithSofiaPhone =
                from student in listOfStudents
                where student.Tel.StartsWith("02")
                select student;
            Console.WriteLine("Students with phone in Sofia");
            foreach (var student in studentsWithSofiaPhone)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Tel}");
            }
            Console.WriteLine();

            //Problem 13.Extract students by marks
            var annonymousStudents =
                from student in listOfStudents
                where student.Marks.Contains(6)
                select new
                {
                    FullName = string.Format("{0} {1}", student.FirstName, student.LastName),
                    Marks = student.Marks,
                };
            Console.WriteLine("Students with marks '6'");
            foreach (var student in annonymousStudents)
            {
                Console.WriteLine($"{student.FullName}");
            }
            Console.WriteLine();

            //Problem 14. Extract students with two marks
            var studentsWithExactlyTwoMarksTwo = listOfStudents.Where(student => student.Marks.Where(mark => mark == 2).Count() == 2);
            Console.WriteLine("Students with two '2' marks");
            foreach (var student in studentsWithExactlyTwoMarksTwo)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.WriteLine();

            //Problem 15. Extract marks
            var enrolled = from student in listOfStudents
                           where student.FacultyNumber.Substring(student.FacultyNumber.Length - 2) == "06"
                           select student.Marks;

            Console.WriteLine("Problem 15. Marks of students that enrolled in 2006:\n");

            foreach (var item in enrolled)
            {
                Console.Write("{0}, ", string.Join(", ", item));
            }

            //Problem 18. Grouped by GroupNumber

            var groupedStudents = from student in listOfStudents
                                  group student by student.GroupNumber into grouped
                                  from gr in grouped
                                  select gr;

            //Problem 19. Grouped by Groupnumber again
            var groupedStudentsExtensions = listOfStudents.GroupBy(s => s.GroupNumber);
        }
    }
}
