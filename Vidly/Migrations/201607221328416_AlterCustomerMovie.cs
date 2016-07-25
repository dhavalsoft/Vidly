namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterCustomerMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("Vidly.Movies", "Genre", c => c.String(nullable: false));
            AlterColumn("Vidly.Movies", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("Vidly.Movies", "Director", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("Vidly.Movies", "Director", c => c.String());
            AlterColumn("Vidly.Movies", "Name", c => c.String());
            DropColumn("Vidly.Movies", "Genre");
        }
    }
}
