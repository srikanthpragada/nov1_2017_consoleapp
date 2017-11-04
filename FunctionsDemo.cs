using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class FunctionsDemo
    {
        public static void Main()
        {
            Print();
            Print("Scott");
            Print( count: 3);  // Named parameter 
            Print("Tim", 3);

            int total;

            total = Sum(10, 20, 30);
            Console.WriteLine(total);

            total = Sum(10, 20, 30,39,19);
            Console.WriteLine(total);
        }

        public static int Sum( params int [] nums)
        {
            int total = 0;

            foreach (int n in nums)
                total += n;

            return total;
        }

        public static void Print(String name = "Anders", int count = 5)
        {
            for (int i = 1; i <= count; i++)
                Console.WriteLine(name);
        }

        public static void Zero(out int v)
        {
             v = 0; 
        }

        public static void Swap(ref int n1, ref int n2)
        {
            int temp = n1;

            n1 = n2;
            n2 = temp; 
        }

        public static int Add(int n1, int n2)
        {
            return n1 + n2; 
        }
    }
}
