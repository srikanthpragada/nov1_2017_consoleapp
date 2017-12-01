using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LinqExpressions
    {
        static void Main(string[] args)
        {
            Book[] books = Book.GetBooks();

            var mybooks = books.OrderBy(b => b.Price). Skip(1).Take(3);

            foreach (var b in mybooks)
                Console.WriteLine("{0} - {1}", b.Title, b.Price);


            var selbooks = from b in books
                           where b.Price > 500
                           orderby b.Price descending
                           select new { Title = b.Title, Price = b.Price * 1.12 };

            //foreach (var b in selbooks)
            //    Console.WriteLine("{0} - {1}", b.Title, b.Price);
        }

    }
}
