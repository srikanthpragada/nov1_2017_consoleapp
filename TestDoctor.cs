using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    abstract class Doctor
    {
        protected String name, dept;
        public Doctor(string name, string dept)
        {
            this.name = name;
            this.dept = dept; 
        }

        public virtual void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(dept);
        }
        public abstract int GetRem();
    }

    class RDoctor : Doctor
    {
        protected int salary;

        public RDoctor(string name, string dept, int salary) 
               : base(name,dept)
        {
            this.salary = salary;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(salary);
        }
        public override int GetRem()
        {
            return salary;
        }
    }

    class Consultant : Doctor
    {
        protected int visits, charge;

        public Consultant(string name, string dept, int visits, int charge)
               : base(name, dept)
        {
            this.visits = visits;
            this.charge = charge;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(visits);
            Console.WriteLine(charge);
        }
        public override int GetRem()
        {
            return visits * charge;
        }
    }

    class TestDoctor
    {
        static void Main(string[] args)
        {
            Consultant c = new Consultant("Dr. Bill", "Card", 5,1000);
            Print(c);

            RDoctor r = new RDoctor("Dr. Steve", "Ped", 400000);
            Print(r);
        }

        static void Print(Doctor d)
        {
            d.Print(); // Runtime Polymorphism
            int rem = d.GetRem();  // Runtime Polymorphism
            if (rem < 10000)
                Console.WriteLine($"Pay {rem} by cash");
            else
                Console.WriteLine($"Pay {rem} by NEFT");

        }

        //static void Print(Consultant c)
        //{
        //    c.Print();
        //    int rem = c.GetRem();

        //    if (rem < 10000)
        //        Console.WriteLine($"Pay {rem} by cash");
        //    else
        //        Console.WriteLine($"Pay {rem} by NEFT");
        //}


    }
}
