namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        { 
            Sql("INSERT INTO Vidly.Genre VALUES('Kids')");
            Sql("INSERT INTO Vidly.Genre VALUES('Science')");
            Sql("INSERT INTO Vidly.Genre VALUES('Drama')");
            Sql("INSERT INTO Vidly.Genre VALUES('Action')");
            Sql("INSERT INTO Vidly.Genre VALUES('Historical')");
            Sql("INSERT INTO Vidly.Genre VALUES('Comedy')");
            Sql("INSERT INTO Vidly.Genre VALUES('Romance')");
            Sql("INSERT INTO Vidly.Genre VALUES('Crime')");
            Sql("INSERT INTO Vidly.Genre VALUES('Musical')");
            Sql("INSERT INTO Vidly.Genre VALUES('War')");
        }
        
        public override void Down()
        {
        }
    }
}
