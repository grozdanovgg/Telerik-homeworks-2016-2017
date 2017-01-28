using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    //Problem 7. Timer

    //Using delegates write a class Timer that can execute certain method at each t seconds.
    class TimerTest
    {
        private static void SayHello()
        {
            Console.WriteLine("The meaning of life is 42");
        }

        public static void Main()
        {
            var timer = new Timer(1, SayHello);
            timer.Execute();
        }
    }
}
