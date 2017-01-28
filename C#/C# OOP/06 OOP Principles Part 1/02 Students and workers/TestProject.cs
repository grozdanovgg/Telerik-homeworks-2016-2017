using System;
using System.Collections.Generic;
using System.Linq;
namespace _02_Students_and_workers
{
    class Program
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort 
            //them by grade in ascending order (use LINQ or OrderBy() extension method)

            List<Student> studenList = new List<Student>(10);
            studenList.Add(new Student("Pesho", "Peshev", 7));
            studenList.Add(new Student("Tosho", "Toshev", 12));
            studenList.Add(new Student("Gosho", "Goshev", 9));
            studenList.Add(new Student("Mesho", "Meshev", 5));
            studenList.Add(new Student("Tresho", "Treshev", 5));
            studenList.Add(new Student("Kesho", "Keshev", 8));
            studenList.Add(new Student("Vosho", "Voshev", 11));
            studenList.Add(new Student("Josho", "Joshev", 11));
            studenList.Add(new Student("Kosho", "Koshev", 12));
            studenList.Add(new Student("Posho", "Poshev", 3));

            var orderedStudents = studenList.OrderBy(person => person.Grade).ToList();
            Console.WriteLine("Unordered student list");
            Console.WriteLine(string.Join("\r\n", studenList));
            Console.WriteLine();
            Console.WriteLine("Ordered by first grade");
            Console.WriteLine(string.Join("\r\n", orderedStudents));
            Console.WriteLine();

            List<Worker> workersList = new List<Worker>(10);
            workersList.Add(new Worker("Penko", "Gemansov", 300, 6));
            workersList.Add(new Worker("Ganko", "Provansov", 400, 6));
            workersList.Add(new Worker("Vanko", "Suskov", 800, 12));
            workersList.Add(new Worker("Conko", "Zelkov", 900, 10));
            workersList.Add(new Worker("Tqnko", "Tenkov", 150, 8));
            workersList.Add(new Worker("Rusko", "Genkov", 180, 4));
            workersList.Add(new Worker("Ganco", "Minov", 1000, 12));
            workersList.Add(new Worker("Vanko", "Tosov", 400, 7));
            workersList.Add(new Worker("Kinko", "Buhov", 500, 8));
            workersList.Add(new Worker("Rinko", "Sestov", 200, 8));

            var orderedWorkers = workersList.OrderByDescending(money => money.MoneyPerHour);
            Console.WriteLine("Unordered workers list");
            Console.WriteLine(string.Join("\r\n", workersList));
            Console.WriteLine();
            Console.WriteLine("Ordered by money per hour");
            Console.WriteLine(string.Join("\r\n", orderedWorkers));
            Console.WriteLine();



            IEnumerable<Human> mergedHumanLists = new List<Human>()
                .Concat(orderedStudents)
                .Concat(orderedWorkers)
                .OrderBy(human => human.LastName)
                .OrderBy(human => human.FirstName);
            Console.WriteLine("merged list: ");
            foreach (var human in mergedHumanLists)
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }



        }
    }
}
