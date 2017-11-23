using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ArrayUtil<T>
    { 
        T [] a;

        public ArrayUtil(T [] a)
        {
           this.a = a; 
        }

        public void Print()
        {
            foreach (T n in a)
                Console.WriteLine(n);
        }

        public void Reset()
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = default(T);
        }
    }

    class  MyStack<T>
    {
        T[] data = new T[10];
        int top = 0; 
        public void Push(T v)
        {
            // code
        }

        public T Pop()
        {
            // code
            return default(T);
        }

        public int Length
        {
            get
            {
                return top;
            }
        }
    }
    class GenericsDemo
    {
        static void Print<T>(T [] a)
        {
            foreach (T v in a)
                Console.WriteLine(v);
        }

        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30 };
            Print(a);

            string[] names = { "Bill", "Steve", "Mike" };
            Print(names);


            var au = new ArrayUtil<int>(a);
            au.Print();
            au.Reset();
            

            var sa = new ArrayUtil<string>(names);
            sa.Print();

            var  s = new MyStack<string>();
            s.Push("Abc");
            Console.WriteLine(s.Pop());
        }
    }
}
