using BookHomeWork.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            using (LibraryContext context = new LibraryContext())
            {
                Book book = new Book();
                book.Title = "Кара создер";
                book.Author = "Абай Кунанбай";
                book.ISBN = "5-345-4-456345";
                book.Genres = "Исторический";
                context.Books.Add(book);
                context.SaveChanges();
            }
        }
    }
}
