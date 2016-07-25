namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Vidly.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        SignUpFee = c.Double(nullable: false),
                        DurationInMonths = c.Byte(nullable: false),
                        Discount = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("Vidly.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("Vidly.Customers", "MembershipTypeId");
            AddForeignKey("Vidly.Customers", "MembershipTypeId", "Vidly.MembershipTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("Vidly.Customers", "MembershipTypeId", "Vidly.MembershipTypes");
            DropIndex("Vidly.Customers", new[] { "MembershipTypeId" });
            DropColumn("Vidly.Customers", "MembershipTypeId");
            DropTable("Vidly.MembershipTypes");
        }
    }
}
