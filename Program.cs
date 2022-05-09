using System;
using System.Collections.Generic;
using task18.Models;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Book book1 = new Book("eli", "murad", 200);
            Book book = new Book("yuzuk", "murad", 200);
            List<Book> books = new List<Book>();
            books.Add(book);
            books.Add(book1);

            Library library = new Library();
            library.Books = books;
            library.SearchBooks("yuzuk");




        }
    }
}
