using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardgameDatabase.Migrations
{
    public partial class fakedatatest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "Name", "City", "Country", "PostCode", "Adress" },
                values: new object[] { "George", "George", "France", "8800", "George" });

            migrationBuilder.InsertData(
                table: "Boardgames",
                columns: new[] { "Id", "ForSale", "Keeper", "MaxPlayers", "MinPlayers", "Name", "Owner", "Tags" },
                values: new object[] { 1, false, "George", 5, 2, "Kemet", "George", "Strategy,Area Controll,Dudes on the map,Beginner" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Boardgames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Adresses",
                keyColumn: "Name",
                keyValue: "George");
        }
    }
}
