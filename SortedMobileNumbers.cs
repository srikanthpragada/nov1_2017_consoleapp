using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class SortedMobileNumbers
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"f:\classroom\phonenumbers.txt");

            var numbers = new SortedSet<String>();

            while(true)
            {
                string line = file.ReadLine();
                if (line == null)
                    break;

                if (line.Trim().Length > 0)  // ignore blank lines 
                {
                    string[] phones = line.Split(',', ' ', ':');

                    foreach (string phone in phones)
                    {
                        if (phone.Length == 10)
                            numbers.Add(phone);
                    }
                }
            }

            file.Close();

            foreach(string phone in numbers)
                Console.WriteLine(phone);

        }
    }
}
