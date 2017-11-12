using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class WriteNames
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("names.txt");

            while(true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                    break;
                sw.WriteLine(line);
            }

            sw.Close();
        }
    }
}
