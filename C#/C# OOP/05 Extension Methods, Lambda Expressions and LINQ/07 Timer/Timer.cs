using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Timer
{
    class Timer
    {
        // delegate
        public delegate void TheAction(); // hold the action

        // properties
        public TheAction action { get; set; }
        public int IntervalSeconds { get; set; }

        // constructor
        public Timer(int seconds, TheAction action)
        {
            this.IntervalSeconds = seconds;
            this.action = action;
        }

        // other methods
        public void Execute()
        {
            var watch = new Stopwatch();

            while (true)
            {
                watch.Start();
                if (watch.ElapsedMilliseconds == IntervalSeconds * 1000)
                {
                    action();
                    watch.Reset();
                }
            }
        }
    }
}
