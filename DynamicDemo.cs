using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DynamicDemo
    {
        static void Main(string[] args)
        {
            dynamic v = new Person("Abc", 10);
            v.Print();

            v = new Time();
            v.Print();

        }
    }
}
