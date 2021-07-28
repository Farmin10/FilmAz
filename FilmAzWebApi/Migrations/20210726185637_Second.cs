using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmAzWebApi.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmAndLanguages",
                table: "FilmAndLanguages");

            migrationBuilder.DropIndex(
                name: "IX_FilmAndLanguages_FilmId",
                table: "FilmAndLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmAndFamousActors",
                table: "FilmAndFamousActors");

            migrationBuilder.DropIndex(
                name: "IX_FilmAndFamousActors_FilmId",
                table: "FilmAndFamousActors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmAndCategories",
                table: "FilmAndCategories");

            migrationBuilder.DropIndex(
                name: "IX_FilmAndCategories_CategoryId",
                table: "FilmAndCategories");

            migrationBuilder.DropColumn(
                name: "FilmLanguageId",
                table: "FilmAndLanguages");

            migrationBuilder.DropColumn(
                name: "FilmFamousActorId",
                table: "FilmAndFamousActors");

            migrationBuilder.DropColumn(
                name: "FilmCategoryId",
                table: "FilmAndCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmAndLanguages",
                table: "FilmAndLanguages",
                columns: new[] { "FilmId", "LanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmAndFamousActors",
                table: "FilmAndFamousActors",
                columns: new[] { "FilmId", "FamousActorId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmAndCategories",
                table: "FilmAndCategories",
                columns: new[] { "CategoryId", "FilmId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmAndLanguages",
                table: "FilmAndLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmAndFamousActors",
                table: "FilmAndFamousActors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FilmAndCategories",
                table: "FilmAndCategories");

            migrationBuilder.AddColumn<int>(
                name: "FilmLanguageId",
                table: "FilmAndLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FilmFamousActorId",
                table: "FilmAndFamousActors",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "FilmCategoryId",
                table: "FilmAndCategories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmAndLanguages",
                table: "FilmAndLanguages",
                column: "FilmLanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmAndFamousActors",
                table: "FilmAndFamousActors",
                column: "FilmFamousActorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FilmAndCategories",
                table: "FilmAndCategories",
                column: "FilmCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndLanguages_FilmId",
                table: "FilmAndLanguages",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndFamousActors_FilmId",
                table: "FilmAndFamousActors",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndCategories_CategoryId",
                table: "FilmAndCategories",
                column: "CategoryId");
        }
    }
}
