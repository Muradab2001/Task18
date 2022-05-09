using System;
using System.Collections.Generic;
using System.Text;

namespace task18.Models
{
    class Book
    {
        public string Code;
        public string Name;
        public string AuthorName;
        public int PageCount;
        private static int _count;

        static Book()
        {
            _count = 0;
        }
        public Book(string name,string authorname,int pagecount)
        {
            _count++;
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            Code = $"{Name.Substring(0, 2)}{_count}";
        }
    }
}
