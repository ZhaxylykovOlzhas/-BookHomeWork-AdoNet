namespace BookHomeWork.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookHomeWork.DataModel.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "BookHomeWork.DataModel.LibraryContext";
        }

        protected override void Seed(BookHomeWork.DataModel.LibraryContext context)
        {
         
        }
    }
}
