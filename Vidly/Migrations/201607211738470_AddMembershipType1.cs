namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO [Vidly].[MembershipTypes] ([Id],[SignUpFee],[DurationInMonths],[Discount]) VALUES(1,0,0,0)");
            Sql("INSERT INTO [Vidly].[MembershipTypes] ([Id],[SignUpFee],[DurationInMonths],[Discount]) VALUES(2,30,1,0)");
            Sql("INSERT INTO [Vidly].[MembershipTypes] ([Id],[SignUpFee],[DurationInMonths],[Discount]) VALUES(3,81,3,10)");
            Sql("INSERT INTO [Vidly].[MembershipTypes] ([Id],[SignUpFee],[DurationInMonths],[Discount]) VALUES(4,288,12,20)");
        }
        
        public override void Down()
        {
        }
    }
}
