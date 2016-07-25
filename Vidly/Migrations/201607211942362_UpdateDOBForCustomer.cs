namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDOBForCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("Update Vidly.Customers SET DateofBirth='04/25/1981' Where Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
