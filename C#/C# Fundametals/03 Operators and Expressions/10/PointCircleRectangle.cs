using System;
class PointCircleRectangle
{
    static void Main()
    {
        //Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y)
        //if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double cx = 1, cy = 1;
        double r = 1.5;
        double z;
        bool rectCheck = -1 <= x && x <= 4 && -1 <= y && y <= 1;
        bool willCheck = Math.Abs(x - cx) <= r && Math.Abs(y - cy) <= r;

        if (willCheck == true)
        {
            z = Math.Sqrt(Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2));
            if (z <= r)
            {
                string result = rectCheck ? "inside circle inside rectangle" : "inside circle outside rectangle";
                Console.WriteLine(result);
            }
            else
            {
                string result = rectCheck ? "outside circle inside rectangle" : "outside circle outside rectangle";
                Console.WriteLine(result);

            }
        }
        else
        {
            string result = rectCheck ? "outside circle inside rectangle" : "outside circle outside rectangle";
            Console.WriteLine(result);
        }
    }
}