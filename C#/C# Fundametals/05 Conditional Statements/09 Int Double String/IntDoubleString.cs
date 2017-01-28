using System;
class IntDoubleString
{
    static void Main()
    {
        string input = Console.ReadLine();
        string input2 = Console.ReadLine();
        switch (input)
        {
            case "integer": Console.WriteLine("{0}", int.Parse(input2) + 1); break;
            case "real": Console.WriteLine("{0:f2}", double.Parse(input2) + 1); break;
            case "text": Console.WriteLine("{0}*", input2); break;

            default:
                break;
        }
    }
}