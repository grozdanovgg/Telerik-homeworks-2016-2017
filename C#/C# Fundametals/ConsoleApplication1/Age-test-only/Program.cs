using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter your birthday in format MM.DD.YYYY");

        DateTime today = DateTime.Today;
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());

        int age;

        if (today.Month > birthday.Month)
        {
            age = today.Year - birthday.Year;
        }
        else
        age = today.Year - birthday.Year -1;

        Console.WriteLine(age);
        Console.WriteLine(age + 10);
    }
}