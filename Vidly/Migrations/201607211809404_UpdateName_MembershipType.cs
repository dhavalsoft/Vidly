namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateName_MembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Vidly.MembershipTypes SET Name = '' WHERE Id=1");
            Sql("UPDATE Vidly.MembershipTypes SET Name = 'Pay as You Go' WHERE Id=2");
            Sql("UPDATE Vidly.MembershipTypes SET Name = 'Quartely' WHERE Id=3");
            Sql("UPDATE Vidly.MembershipTypes SET Name = 'Yearly' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
