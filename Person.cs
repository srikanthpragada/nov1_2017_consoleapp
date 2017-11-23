using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Person : IComparable<Person>
    {
        private String name;
        private int age; 
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age; 
        }
        public override int GetHashCode()
        {
            return this.age; 
        }
        public override string ToString()
        {
            return name + " - " + age;
        }

        public override bool Equals(object obj)
        {
            Person other = obj as Person;  //  (Person) obj
            return this.name == other.name && this.age == other.age;
        }
        // 0 : this == other , > 0 : this > other, < 0 : this < other 
        public int CompareTo(Person other)
        {
            Console.WriteLine(this + ":" + other);
            return this.age - other.age;
        }
        public void Print()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
    class TestPerson
    {
        static void Main(string[] args)
        {
           Person[] people =
           {
                new Person("Mr. Scott",55),
                new Person("Mr. Bill",58),
                new Person("Mr. Resig",33),
                new Person("Mr. Allen",40)
           };

            Array.Sort(people);

            foreach (Person p in people)
                Console.WriteLine(p);

        }
    }
}
