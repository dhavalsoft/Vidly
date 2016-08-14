namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatecolumnAddress : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Vidly.Customers", "Address", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("Vidly.Customers", "Address", c => c.String(maxLength: 100));
        }
    }
}
