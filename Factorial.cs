using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Factorial
    {
        static void Main()
        {
            int num, fact = 1;

            Console.Write("Enter a number : ");
            num = Int32.Parse( Console.ReadLine() );  // String to int

            for (int i = 1; i <= num; i++)
                fact = fact * i;

            Console.WriteLine("Factorial of {0} is {1}",num, fact);
            // String Interpolation - C# 6.0 onwards 
            Console.WriteLine($"Factorial of {num} is {fact}");

        }
    }
}
