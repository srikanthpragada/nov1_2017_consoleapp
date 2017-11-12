using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ReadNames
    {

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("names.txt");
            int total = 0, count = 0;
            while (true)
            {
                string line = sr.ReadLine();
                if (line == null)  // EOF
                    break;
                total += line.Length;
                count++;
                Console.WriteLine(line);

            }

            Console.WriteLine("Average : {0} ", total / count);


        }

    }
}
