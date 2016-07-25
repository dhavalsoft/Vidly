namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDOBToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("Vidly.Customers", "DateofBirth", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("Vidly.Customers", "DateofBirth");
        }
    }
}
