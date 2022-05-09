using System;
using System.Collections.Generic;
using System.Text;
using task18.Models_task2;

namespace task18.Interfaces
{
    interface ILibraryManager
    {
        public List<Book> books { get; }
        void Add(Book book);
        Book ShowInfo(string name);
        List<Book> Search(Predicate<Book> predicate);
        List<Book> Filter(string genre);
    }
}
