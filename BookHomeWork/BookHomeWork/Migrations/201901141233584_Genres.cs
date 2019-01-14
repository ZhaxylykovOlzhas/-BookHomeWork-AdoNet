namespace BookHomeWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "Genres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "Genres");
        }
    }
}
