using System;
class Program
{
    static void Main()
    {
        //int y = 2016;
        //int m = 12;
        //int d = 31;
        //double time;
        //DateTime today = DateTime.Now;
        //DateTime future = new DateTime(y, m, d);

        //time = (future - today).Days;

        //yyyy.MM.dd HH:mm:ss:ffff
        Console.WriteLine(GetBusinessDays(2015, 8, 18, 13, 31, 17));
    }
    public static double GetBusinessDays(DateTime startD, DateTime endD)
    {
        double calcBusinessDays =
            1 + ((endD - startD).TotalDays * 5 -
            (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

        if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
        if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

        return calcBusinessDays;
    }

}