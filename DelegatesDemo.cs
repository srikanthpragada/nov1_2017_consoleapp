using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    class DelegatesDemo
    {

        static void Main(string[] args)
        {
            int[] a = { 10, 11, 20, 23, 57, 66 };

            // int[] ea = Array.FindAll(a, new Predicate<int>(IsEven));
            // int[] ea = Array.FindAll(a, IsEven);  // Method Group Conversion

            //int[] se = Array.FindAll(a,
            //                     delegate (int n) {
            //                         return n % 2 != 0;
            //                     }
            //                  );

            int[] se = Array.FindAll(a, n => n % 2 != 0);
                                
            foreach (int n in se)
                Console.WriteLine(n);

        }

        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }


    }
}
