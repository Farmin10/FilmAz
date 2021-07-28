using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmAzWebApi.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_IMDBs_IMDBId",
                table: "Films");

            migrationBuilder.DropTable(
                name: "IMDBs");

            migrationBuilder.DropIndex(
                name: "IX_Films_IMDBId",
                table: "Films");

            migrationBuilder.AlterColumn<double>(
                name: "IMDBId",
                table: "Films",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IMDBId",
                table: "Films",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateTable(
                name: "IMDBs",
                columns: table => new
                {
                    IMDBId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMDBPoint = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMDBs", x => x.IMDBId);
                });

            migrationBuilder.InsertData(
                table: "IMDBs",
                columns: new[] { "IMDBId", "IMDBPoint" },
                values: new object[,]
                {
                    { 1, 1.0 },
                    { 29, 9.5999999999999996 },
                    { 28, 9.5 },
                    { 27, 9.4000000000000004 },
                    { 26, 9.1999999999999993 },
                    { 25, 8.9000000000000004 },
                    { 24, 8.5999999999999996 },
                    { 23, 8.3000000000000007 },
                    { 22, 8.0 },
                    { 21, 7.9000000000000004 },
                    { 20, 7.5999999999999996 },
                    { 19, 7.2999999999999998 },
                    { 18, 7.0 },
                    { 17, 6.9000000000000004 },
                    { 30, 9.8000000000000007 },
                    { 16, 6.5999999999999996 },
                    { 14, 6.0 },
                    { 13, 5.9000000000000004 },
                    { 12, 5.5999999999999996 },
                    { 11, 5.2999999999999998 },
                    { 10, 5.0 },
                    { 9, 4.9000000000000004 },
                    { 8, 4.5999999999999996 },
                    { 7, 4.2999999999999998 },
                    { 6, 3.5 },
                    { 5, 3.0 },
                    { 4, 2.5 },
                    { 3, 2.0 },
                    { 2, 1.5 },
                    { 15, 6.2999999999999998 },
                    { 31, 9.9000000000000004 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_IMDBId",
                table: "Films",
                column: "IMDBId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_IMDBs_IMDBId",
                table: "Films",
                column: "IMDBId",
                principalTable: "IMDBs",
                principalColumn: "IMDBId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
