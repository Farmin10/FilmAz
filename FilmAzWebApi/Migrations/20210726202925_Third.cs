using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmAzWebApi.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_IMDBs_IMDBId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "IMBDId",
                table: "Films");

            migrationBuilder.AlterColumn<int>(
                name: "IMDBId",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_IMDBs_IMDBId",
                table: "Films",
                column: "IMDBId",
                principalTable: "IMDBs",
                principalColumn: "IMDBId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_IMDBs_IMDBId",
                table: "Films");

            migrationBuilder.AlterColumn<int>(
                name: "IMDBId",
                table: "Films",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IMBDId",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Films_IMDBs_IMDBId",
                table: "Films",
                column: "IMDBId",
                principalTable: "IMDBs",
                principalColumn: "IMDBId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
