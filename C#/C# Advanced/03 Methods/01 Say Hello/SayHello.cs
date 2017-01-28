using System;
class SayHello
{
    static void Main()
    {
        Hello();
    }
    static void Hello() // PrintLogo is the method's name
    {
        string input = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", input);
    }

}