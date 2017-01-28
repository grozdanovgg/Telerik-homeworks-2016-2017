using System;
using System.Collections.Generic;

namespace OOPPrinciplesPart1
{
    class TestProject
    {
        static void Main()
        {
            //var person1 = new Person("Pesgp");

            //person1.Comment = "test";

            //Console.WriteLine(person1.Comment);
            
            var biology = new Disciplines("Biology", 28, 16, "extremly hard class");
            var physics = new Disciplines("Physics", 40, 50, "for the first time in the school");
            var mathematics = new Disciplines("Mathematics", 50, 50);
            var literature = new Disciplines("Literature", 60, 40);
            var history = new Disciplines("History", 34, 0);

            var teacherOne = new Teacher("Petka Petkanova");
            var teacherTwo = new Teacher("Nenka Nenkova");
            var teacherThree = new Teacher("Ivan Ivanov");

            teacherOne.ListOfDisciplines.Add(biology);
            teacherOne.ListOfDisciplines.Add(physics);
            teacherTwo.ListOfDisciplines.Add(literature);
            teacherTwo.ListOfDisciplines.Add(history);
            teacherThree.ListOfDisciplines.Add(physics);
            teacherThree.ListOfDisciplines.Add(biology);
            teacherThree.ListOfDisciplines.Add(mathematics);

            var biologyClass = new ClassOfStudents("Boilogy class");
            var physicsClass = new ClassOfStudents("Physics class");
            var mathClass = new ClassOfStudents("Math class");

            biologyClass.ListOfTeachers.Add(teacherOne);
            physicsClass.ListOfTeachers.Add(teacherThree);
            mathClass.ListOfTeachers.Add(teacherThree);

            List<ClassOfStudents> allClasses = new List<ClassOfStudents>();
            allClasses.Add(biologyClass);
            allClasses.Add(physicsClass);
            allClasses.Add(mathClass);

            var school131SOU = new School(allClasses);
            var studentsOf131SOU = school131SOU.ListOfStudents;
            

            biologyClass.Comment = "blablabla";
            var idClass = biologyClass.TextIdentifier;
            Console.WriteLine(idClass);
        }
    }
}
