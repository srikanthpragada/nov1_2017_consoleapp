using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            int [] marks = { 79, 88, 69, 48, 78 ,88,65 };


            for (int i = 0; i < marks.Length ; i++)
                Console.WriteLine(marks[i]);

            foreach (int m in marks)
                Console.WriteLine(m);


        }
    }
}
