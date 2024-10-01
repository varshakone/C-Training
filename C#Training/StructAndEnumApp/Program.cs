using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndEnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(101, "Android", "Android", publishMonth.January);

            var bookdetails = book.getBookList();

            Console.WriteLine(bookdetails);
        

            Console.ReadKey();
        }
    }
}
