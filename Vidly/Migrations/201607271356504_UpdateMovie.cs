namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMovie : DbMigration
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

            CreateTable(
                "Vidly.Genre",
                c => new
                    {
                        GenreId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.GenreId);
            
            AddColumn("Vidly.Movies", "GenreId", c => c.Int(nullable: false));
            CreateIndex("Vidly.Movies", "GenreId");
            AddForeignKey("Vidly.Movies", "GenreId", "Vidly.Genre", "GenreId", cascadeDelete: true);
            //DropColumn("Vidly.Movies", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("Vidly.Movies", "Genre", c => c.String(nullable: false));
            DropForeignKey("Vidly.Movies", "GenreId", "Vidly.Genre");
            DropIndex("Vidly.Movies", new[] { "GenreId" });
            DropColumn("Vidly.Movies", "GenreId");
            DropTable("Vidly.Genre");
        }
    }
}
