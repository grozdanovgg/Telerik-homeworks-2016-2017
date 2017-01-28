using System;

class FloatingPointTypes
{
    static void Main()
    {
        double FirstA = double.Parse(Console.ReadLine());
        double SecondA = double.Parse(Console.ReadLine());

        double ResultA = FirstA - SecondA;
        double ResultPositive = Math.Abs(ResultA);
        bool Validate;
        Validate = (0.000001 >= ResultPositive);
        Console.WriteLine(Validate.ToString().ToLower());
    }
}