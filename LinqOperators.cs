using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class LinqOperators
    {
        static void Main(string[] args)
        {
            Book[] books = Book.GetBooks();

            var avgprice = books.Average(b => b.Price);
            Console.WriteLine(avgprice);

            //var selbooks = books.Where(b => b.Price > 500)
            //                    .OrderBy(b => b.Price);

            var selbooks = books.Where (b => b.Price > avgprice)
                                .OrderBy(b => b.Price)
                                .Select(b => new { Title = b.Title, Price = b.Price * 1.12 });


            foreach (var b in selbooks)
                Console.WriteLine("{0} - {1}", b.Title, b.Price);

        }

        static bool CostlyBook(Book b)
        {
            return b.Price > 600;
        }
    }
}
