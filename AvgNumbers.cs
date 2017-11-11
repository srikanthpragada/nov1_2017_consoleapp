using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class AvgNumbers
    {
        public static void Main()
        {
            int count = 0, sum = 0, num;
            // take 5 numbers and display average
            for (int i = 1; i <= 5; i++)
            {
                try
                {
                    Console.Write("Enter a number:");
                    num = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(100 / num);
                    sum += num;
                    count++;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error -->" + ex.Message);
                }
                finally
                {
                    Console.WriteLine("Finally!");
                }
            } // for
            Console.WriteLine("Average : {0} ", sum / count);
        } // end of Main()
    }
}
