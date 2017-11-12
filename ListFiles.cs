using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ListFiles
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"f:\classroom\nov1\consoleapp");

            foreach(FileInfo file in dir.GetFiles())
            {
                if (file.Name.EndsWith(".cs"))
                    Print(file.FullName);
            }
        }

        static void Print(string filename)
        {
            Console.WriteLine($"******** {filename} *************");
        }
    }
}
