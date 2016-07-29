namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnNoOfDVDs : DbMigration
    {
        public override void Up()
        {
            AddColumn("Vidly.Movies", "NoOfDVDs", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("Vidly.Movies", "NoOfDVDs");
        }
    }
}
