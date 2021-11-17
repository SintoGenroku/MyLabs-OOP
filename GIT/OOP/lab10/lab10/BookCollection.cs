using System;
using System.Collections.Generic;
using System.Text;

namespace lab10
{
    class BookCollection
    {
        public static Dictionary<string, int> Bookshelf;

        public BookCollection(Book book) 
        {
            Bookshelf.Add(Book.key, Book.value);
        }
        public  void  Add(string key, int value) 
        {

        }
    }
}
