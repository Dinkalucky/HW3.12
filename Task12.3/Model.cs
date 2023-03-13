using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Task12._3
{
    internal static class Model
    {
        public static string StartTimeDisplay{
            get { return "00:00:00"; }
        }
        public static Stopwatch StopWatch
        {
            get { return Stopwatch.StartNew(); }
        }

        public static Timer Timer
        {
            get { return new Timer(1000); }
        }
    }
}
