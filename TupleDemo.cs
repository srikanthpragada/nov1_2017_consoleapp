using HRLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class TupleDemo
    {
        static void Main(string[] args)
        {
            var t1 = Tuple.Create<int,string,DateTime> (10, "Abc", DateTime.Now);
            Department d = new Department { Id = 1, Name = "IT"};
            Job j = new Job { Id = "PROG", Title = "Programmer" };
        }
    }

    class PartimeJob : Job
    {

    }
}
