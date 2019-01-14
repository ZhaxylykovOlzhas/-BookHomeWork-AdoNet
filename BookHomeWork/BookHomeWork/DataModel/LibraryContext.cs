namespace BookHomeWork.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class LibraryContext : DbContext
    {
        public LibraryContext()
            : base("name=LabraryContext")
        {
        }
        public DbSet<Book> Books { get; set; } 
    }
}