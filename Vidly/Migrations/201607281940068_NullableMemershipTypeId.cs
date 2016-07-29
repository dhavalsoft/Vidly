namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NullableMemershipTypeId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Vidly.Customers", "MembershipTypeId", "Vidly.MembershipTypes");
            DropIndex("Vidly.Customers", new[] { "MembershipTypeId" });
            AlterColumn("Vidly.Customers", "MembershipTypeId", c => c.Byte());
            CreateIndex("Vidly.Customers", "MembershipTypeId");
            AddForeignKey("Vidly.Customers", "MembershipTypeId", "Vidly.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("Vidly.Customers", "MembershipTypeId", "Vidly.MembershipTypes");
            DropIndex("Vidly.Customers", new[] { "MembershipTypeId" });
            AlterColumn("Vidly.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("Vidly.Customers", "MembershipTypeId");
            AddForeignKey("Vidly.Customers", "MembershipTypeId", "Vidly.MembershipTypes", "Id", cascadeDelete: true);
        }
    }
}
