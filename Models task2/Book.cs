using System;
using System.Collections.Generic;
using System.Text;
using task18.Interfaces;

namespace task18.Models_task2
{
    class Book 
    {
        public string Name;
        public string Author;
        public int PageCount;
        public string Genre;
        public Book(string name,string author,int pagecount,string genre)
        {
            Name = name;
            Author = author;
            PageCount = pagecount;
            Genre = genre;
        }
    }
}
