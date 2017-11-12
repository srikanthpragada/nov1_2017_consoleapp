using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DatesDemo
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Today;
            DateTime soy = new DateTime(2017, 1, 1);

            TimeSpan ts = now.Subtract(soy);
            Console.WriteLine(ts.Days);

        }
    }
}
