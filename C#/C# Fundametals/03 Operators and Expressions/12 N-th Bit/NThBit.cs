using System;
class Program
{
    static void Main()
    {
        ulong p = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        ulong num = (p >> n) & 1;
      
        Console.WriteLine(num);
    }
}