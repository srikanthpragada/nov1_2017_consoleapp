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
        private string[] skills = new string[5];

        // Constructor
        public Employee(string name, int salary, params string[] skills)
        {
            this.name = name;
            this.salary = salary;
            for (int i = 0; i < skills.Length; i++)
                this.skills[i] = skills[i];
        }
        // Indexer 
        public string this[int index]
        {
            get
            {
                return this.skills[index];
            }
            set
            {
                this.skills[index] = value;
            }
        }


        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    this.salary = value;
            }
        }
        // Readonly property 
        public int NetSalary
        {
            get
            {
                return salary + salary * 40 / 100;
            }
        }


        public void Print()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.salary);
        }
    }

    class TestEmployee
    {
        public static void Main()
        {
            Employee e; // Object reference

            e = new Employee("Scott", 50000, "Java", "Oracle", "C#");
            e[3] = "Angular";

            // e.Print();

            Console.WriteLine(e.Salary);
            Console.WriteLine(e.NetSalary);

            e.Salary = 60000;
            Console.WriteLine(e.NetSalary);

            





        }

    }
}
