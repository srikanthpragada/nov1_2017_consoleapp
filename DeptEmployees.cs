using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class DeptEmployees
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("../../deptemployees.txt");

            var depts = new SortedDictionary<String,SortedSet<string>>();

            while(true)
            {
                string line = file.ReadLine();
                if (line == null)
                    break;

                if (line.Trim().Length > 0)  // ignore blank lines 
                {
                    string[] parts = line.Split(',');
                    var deptno = parts[0];
                    var empname = parts[1];

                    if (! depts.ContainsKey(deptno))
                    {
                        // add new entry with dept number and employee in sortedset
                        var employees = new SortedSet<string>();
                        employees.Add(empname);
                        depts.Add(deptno, employees);
                    }
                    else
                    {
                        // add employee to existing dept 
                        var employees = depts[deptno];
                        employees.Add(empname);
                    }
                }
            }

            file.Close();

            foreach (string deptno in depts.Keys)
            {
                Console.WriteLine(deptno);
                foreach (string name in depts[deptno])
                    Console.WriteLine("   " + name);

            }

        }
    }
}
