namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Vidly.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ReleasedDate = c.DateTime(nullable: false),
                        Director = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("Vidly.Movies");
        }
    }
}
