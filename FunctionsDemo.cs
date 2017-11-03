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
            int a = 10, b = 20;

            Swap(ref a,ref b);

            Console.WriteLine("a = {0}, b = {1}", a, b);

            int num;

            Zero(out num);

            Console.WriteLine(num);
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
