using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简易图书馆书架管理
{
    internal class Bookshelf
    {
        private Book[] _books=new Book[10];
        private int _count = 0;
        public void AddBook(Book book)
        {
            for (int in=0;in<_count;in++)
            {

            }
            do
            {
                _count++;
                Console.WriteLine($"现在书架里有{_count}本书");
            }
            while (_count <= _books.Length) ;

        }
        public Book[] FindBooksByTitle(string keyword)
        {
            foreach (Book book in _books)
            {
                if ()
                {

                }
            }
        }
    }
}
