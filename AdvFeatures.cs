using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Point
    {
        public int x, y;
    }

    static class ExMethod
    {
        public static void Print(this Point p)
        {
            Console.WriteLine("{0},{1}", p.x, p.y);
        }
    }
    class AdvFeatures
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.Print();


        }
    }
}
