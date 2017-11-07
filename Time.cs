using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Time
    {
        // Auto implemented property 
        public int Hours { set; get; }
        public int Mins { set; get; }
        public int Secs { set; get; }
    }

    class TestTime
    {
        static void Main(string[] args)
        {
            Time t = new Time();
            t.Hours = 10;
            t.Mins = 20;
            t.Secs = 30;

            // Object initializer 
            Time t2 = new Time { Hours = 10, Mins = 20 };



        }
    }
}
