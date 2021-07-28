using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmAzWebApi.Migrations
{
    public partial class Five : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IMDBId",
                table: "Films",
                newName: "IMDB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IMDB",
                table: "Films",
                newName: "IMDBId");
        }
    }
}
