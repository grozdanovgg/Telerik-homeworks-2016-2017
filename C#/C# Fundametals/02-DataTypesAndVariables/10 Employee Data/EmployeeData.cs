using System;
class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("First name:");
        String FistName = Console.ReadLine();

        Console.WriteLine("Last name:");
        String LastName = Console.ReadLine();

        Console.WriteLine("Age:");
        String Age = Console.ReadLine();
        byte Agebyte;
        Byte.TryParse(Age, out Agebyte);

        Console.WriteLine("Gender:");
        String Gender = Console.ReadLine();

        Console.WriteLine("Personal ID number:");
        String PersonalIDNumber = Console.ReadLine();
        UInt64 PersonalIDNumberInt;
        UInt64.TryParse(PersonalIDNumber, out PersonalIDNumberInt);

        Console.WriteLine("Unique empoye number:");
        String UniqueEmpoyeNumber = Console.ReadLine();
        UInt32 UniqueEmpoyeNumberInt;
        UInt32.TryParse(UniqueEmpoyeNumber, out UniqueEmpoyeNumberInt);

        Console.WriteLine();
        Console.WriteLine("Ëmployee data:");
        Console.WriteLine(FistName);
        Console.WriteLine(LastName);
        Console.WriteLine(Agebyte);
        Console.WriteLine(Gender);
        Console.WriteLine(PersonalIDNumber);
        Console.WriteLine(UniqueEmpoyeNumber);
    }
}
