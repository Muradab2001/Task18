using System;
using System.Collections.Generic;
using System.Text;
using task18.Interfaces;
using task18.Models_task2;

namespace task18.Services
{
 
    class LibraryManager : ILibraryManager
    {
        public List<Book> booklist;
        public List<Book> books => booklist;
        public void Add(Book book)
        {
            bool chechk = true;
            foreach (Book b in booklist)
            {
                if ((b.Name.ToLower()==book.Name.ToLower()))
                {
                    chechk = false;
                    throw new Exception("SameBookalreadyAddedExpection");
                }
            }
            if (chechk==true)
            {
                booklist.Add(book);
            }           
        }

        public List<Book> Filter(string genre)
        {
            List<Book> books = new List<Book>();
            foreach (Book b in books)
            {
                if (b.Genre.ToLower()==genre.ToLower())
                {
                    books.Add(b);
                }
            }
            return books;
        }

        public List<Book> Search(Predicate<Book> predicate)
        {
     
            List<Book> books = new List<Book>();
            foreach (Book b in booklist)
            {
                if (predicate(b))
                {
                    books.Add(b);
                }
            }
            return books;
        
        }
        public Book ShowInfo(string name)
        {
            foreach (Book b in booklist)
            {
                if (b.Name.ToLower()==name.ToLower())
                    return b;
            }
            throw new Exception("BookNotFoundException");
        }
    }
}
