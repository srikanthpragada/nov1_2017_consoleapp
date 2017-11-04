using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class PrimeNumber
    {
        public static void Main(string [] args)
        {

            if ( args.Length == 0 )
            {
                Console.WriteLine("Sorry! Number is not provided. Quitting!");
                return;
            }

            int num = Int32.Parse(args[0]);

            for(int i = 2; i <= num/2; i ++)
            {
                if ( num % i == 0)
                {
                    Console.WriteLine("Not a prime number!");
                    return;
                }
            }

            Console.WriteLine("Prime Number!");

             
        }
    }
}
