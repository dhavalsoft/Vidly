namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumnAddress : DbMigration
    {
        public override void Up()
        {
            AddColumn("Vidly.Customers", "Address", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("Vidly.Customers", "Address");
        }
    }
}
