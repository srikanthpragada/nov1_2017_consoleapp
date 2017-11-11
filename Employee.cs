using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class InvalidSalaryException : Exception
    {
        public InvalidSalaryException() : base("Invalid Salary : Negative Salary")
        {

        }
    }
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
                else
                    throw new InvalidSalaryException();
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
            foreach (string skill in skills)
            {
                if ( skill != null)
                    Console.WriteLine(skill);
            }
        }
    }

    class OverseasEmployee : Employee
    {
        protected string country;
        protected int allowance; 

        public OverseasEmployee(string name, int salary, string country, int allowance,
                                              params string [] skills)
            : base(name, salary,skills)
        {
            this.country = country;
            this.allowance = allowance;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine(country);
            Console.WriteLine(allowance);
        }

        public new int NetSalary
        {
            get
            {
                return base.NetSalary + allowance;
            }
        }

    }
    class TestEmployee
    {
        public static void Main()
        {
            Employee e;

            e = new Employee("Scott", 50000, "Java", "Oracle", "C#");
            e[3] = "Angular";


            e.Salary = -1000;


            OverseasEmployee oe = new OverseasEmployee("Joe", 60000, "UK",100000, "SAP");
            oe[1] = "Oracle DBA";
            oe[2] = "Windows Admin";

            oe.Print();

            Console.WriteLine(oe.NetSalary);










        }

    }
}
