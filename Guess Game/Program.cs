using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Myfirst2 // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Console.WriteLine(book1.title);
        }




    }
}
