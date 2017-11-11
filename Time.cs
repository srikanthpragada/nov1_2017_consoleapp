using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    struct Time
    {
        public int Hours, Mins, Secs;
    }

    class TestTime
    {
        static void Main(string[] args)
        {
            Time t;

            t.Hours = 10;
            t.Mins = 20;
            t.Secs = 30;

            // Object initializer 
            Time t2 = new Time { Hours = 10, Mins = 20 };



        }
    }
}
