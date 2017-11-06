using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Employee
    {
        // Instance variables
        private String name;  // null
        private int salary;   // 0

        // Constructor
        public Employee (string n, int sal = 0)
        {
            name = n;
            salary = sal;
        }

        public int GetSalary()
        {
            return salary + salary * 40 / 100;
        }

        public void SetSalary(int sal)
        {
            salary = sal;
        }

        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(salary);
        }
    }

    class TestEmployee
    {
        public static void Main()
        {
            Employee e; // Object reference

            e = new Employee("Scott", 50000);
            e.Print();

            Console.WriteLine(e.GetSalary());

            Employee e2 = new Employee("Anders");
            e2.SetSalary(100000);
            e2.SetSalary(75000);
            e2.Print();

            

        }

    }
}
