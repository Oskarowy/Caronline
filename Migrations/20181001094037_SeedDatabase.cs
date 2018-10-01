using Microsoft.EntityFrameworkCore.Migrations;

namespace Caronline.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Skoda')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Opel')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Ford')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Octavia', (SELECT ID FROM Makes WHERE Name ='Skoda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Superb', (SELECT ID FROM Makes WHERE Name ='Skoda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Kodiaq', (SELECT ID FROM Makes WHERE Name ='Skoda'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Insignia', (SELECT ID FROM Makes WHERE Name ='Opel'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Grandland', (SELECT ID FROM Makes WHERE Name ='Opel'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Astra', (SELECT ID FROM Makes WHERE Name ='Opel'))");
        
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Focus', (SELECT ID FROM Makes WHERE Name ='Ford'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Mondeo', (SELECT ID FROM Makes WHERE Name ='Ford'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Kuga', (SELECT ID FROM Makes WHERE Name ='Ford'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes");
        }
    }
}
