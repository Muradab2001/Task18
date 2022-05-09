using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task18.Models
{
 
    class Library
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }
        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> books = Books.FindAll(b => b.Name.ToLower().Contains(name));
            return books;
        }
        public void RemoveAllBookByName(string name)
        {
            foreach (Book b in Books)
            {
                if (b.Name.ToLower() == name.ToLower())
                {
                    Books.Remove(b);
                }
            }
        }
        public List<Book> SearchBooks(string name)
        {
            List<Book> book = Books.FindAll(b => b.Name.ToLower().Contains(name) || b.Code.ToLower().Contains(name) || b.AuthorName.ToLower().Contains(name));
            {
                foreach (Book b in book)
                {
                    Console.WriteLine(b);
                }
            }
            return book;
        }
        public void RemoveByNo(string name)
        {
            foreach (Book b in Books)
            {
                if (b.Code.ToLower() == name.ToLower())
                {
                   Books.Remove(b);
                }
            }
        }
        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            List<Book> book = new List<Book>();
            foreach (Book b in Books)
            {
                if (b.PageCount>min && b.PageCount<max)
                {
                    book.Add(b);
                }
            }
            return book;
   
        }
    }

}
