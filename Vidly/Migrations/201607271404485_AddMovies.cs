namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Star Trek Beyond','22 July 2016','Justin Lin',4)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Hardcore Henry','8 April 2016','Ilya Naishuller',4)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Brothers Of Shaolin', '11/15/2008','Venom Mob Film',4)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Step Brothers', '15 Feb 2008','Adam McKay',6)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('White Chicks', '25 Mar 2004','Keenen Ivory Wayans',6)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('The Hangover', '20 Jan 2009',' Todd Phillips',6)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Wedding Crashers', '20 Jun 2005','David Dobkin',6)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('You''ve Got Mail', '18 December 1998','Nora Ephron',7)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Sleepless in Seattle', ' 25 June 1993','Nora Ephron',7)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Groundhog Day', ' 12 February 1993','Harold Ramis',7)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Armageddon', '1 July 1998','Michael Bay',2)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('The Wraith', ' 21 November 1986','Mike Marvin',2)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Night of the Comet', '16 November 1984 ','Thom Eberhardt',2)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Letters to Juliet', '1 July 1998','Gary Winick',3)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('17 Again', ' 17 April 2009','Burr Steers',3)");
            Sql("INSERT INTO Vidly.Movies(Name,ReleasedDate,Director,GenreId) Values('Ever After: A Cinderella Story', ' 31 July 1998','Andy Tennant',5)");
        }

        public override void Down()
        {
        }
    }
}
