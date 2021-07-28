using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmAzWebApi.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "FamousActors",
                columns: table => new
                {
                    FamousActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FamousActors", x => x.FamousActorId);
                });

            migrationBuilder.CreateTable(
                name: "FilmCountries",
                columns: table => new
                {
                    FilmCountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmCountries", x => x.FilmCountryId);
                });

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

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "ProductionYears",
                columns: table => new
                {
                    ProductionYearId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionYears", x => x.ProductionYearId);
                });

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilmDirector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHD = table.Column<bool>(type: "bit", nullable: false),
                    ProductionYearId = table.Column<int>(type: "int", nullable: false),
                    IMBDId = table.Column<int>(type: "int", nullable: false),
                    IMDBId = table.Column<int>(type: "int", nullable: true),
                    FilmCountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                    table.ForeignKey(
                        name: "FK_Films_FilmCountries_FilmCountryId",
                        column: x => x.FilmCountryId,
                        principalTable: "FilmCountries",
                        principalColumn: "FilmCountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Films_IMDBs_IMDBId",
                        column: x => x.IMDBId,
                        principalTable: "IMDBs",
                        principalColumn: "IMDBId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Films_ProductionYears_ProductionYearId",
                        column: x => x.ProductionYearId,
                        principalTable: "ProductionYears",
                        principalColumn: "ProductionYearId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmAndCategories",
                columns: table => new
                {
                    FilmCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmAndCategories", x => x.FilmCategoryId);
                    table.ForeignKey(
                        name: "FK_FilmAndCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmAndCategories_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmAndFamousActors",
                columns: table => new
                {
                    FilmFamousActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    FamousActorId = table.Column<int>(type: "int", nullable: false),
                    IsMainRole = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmAndFamousActors", x => x.FilmFamousActorId);
                    table.ForeignKey(
                        name: "FK_FilmAndFamousActors_FamousActors_FamousActorId",
                        column: x => x.FamousActorId,
                        principalTable: "FamousActors",
                        principalColumn: "FamousActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmAndFamousActors_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FilmAndLanguages",
                columns: table => new
                {
                    FilmLanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FilmId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmAndLanguages", x => x.FilmLanguageId);
                    table.ForeignKey(
                        name: "FK_FilmAndLanguages_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmAndLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FamousActors",
                columns: new[] { "FamousActorId", "ActorName" },
                values: new object[,]
                {
                    { 1, "Farmin" },
                    { 2, "Zaur" },
                    { 3, "Hasan" }
                });

            migrationBuilder.InsertData(
                table: "FilmCountries",
                columns: new[] { "FilmCountryId", "CountryName" },
                values: new object[,]
                {
                    { 1, "America" },
                    { 2, "Turkey" },
                    { 3, "Hindu" },
                    { 4, "Columbia" }
                });

            migrationBuilder.InsertData(
                table: "IMDBs",
                columns: new[] { "IMDBId", "IMDBPoint" },
                values: new object[,]
                {
                    { 18, 7.0 },
                    { 19, 7.2999999999999998 },
                    { 20, 7.5999999999999996 },
                    { 21, 7.9000000000000004 },
                    { 22, 8.0 },
                    { 23, 8.3000000000000007 },
                    { 28, 9.5 },
                    { 26, 9.1999999999999993 },
                    { 27, 9.4000000000000004 },
                    { 17, 6.9000000000000004 },
                    { 29, 9.5999999999999996 },
                    { 30, 9.8000000000000007 },
                    { 31, 9.9000000000000004 },
                    { 25, 8.9000000000000004 },
                    { 16, 6.5999999999999996 },
                    { 24, 8.5999999999999996 },
                    { 14, 6.0 },
                    { 15, 6.2999999999999998 },
                    { 1, 1.0 },
                    { 3, 2.0 },
                    { 4, 2.5 },
                    { 5, 3.0 },
                    { 6, 3.5 },
                    { 7, 4.2999999999999998 },
                    { 2, 1.5 },
                    { 8, 4.5999999999999996 },
                    { 9, 4.9000000000000004 },
                    { 10, 5.0 },
                    { 11, 5.2999999999999998 },
                    { 12, 5.5999999999999996 },
                    { 13, 5.9000000000000004 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "LanguageId", "LanguageName" },
                values: new object[,]
                {
                    { 1, "Turkish subtitle" },
                    { 2, "Turkish dubbing" }
                });

            migrationBuilder.InsertData(
                table: "ProductionYears",
                columns: new[] { "ProductionYearId", "Year" },
                values: new object[,]
                {
                    { 13, 2012 },
                    { 14, 2013 }
                });

            migrationBuilder.InsertData(
                table: "ProductionYears",
                columns: new[] { "ProductionYearId", "Year" },
                values: new object[,]
                {
                    { 15, 2014 },
                    { 16, 2015 },
                    { 19, 2018 },
                    { 18, 2017 },
                    { 20, 2019 },
                    { 12, 2011 },
                    { 17, 2016 },
                    { 11, 2010 },
                    { 3, 2002 },
                    { 9, 2008 },
                    { 8, 2007 },
                    { 7, 2006 },
                    { 6, 2005 },
                    { 5, 2004 },
                    { 4, 2003 },
                    { 2, 2001 },
                    { 1, 2000 },
                    { 21, 2020 },
                    { 10, 2009 },
                    { 22, 2021 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndCategories_CategoryId",
                table: "FilmAndCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndCategories_FilmId",
                table: "FilmAndCategories",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndFamousActors_FamousActorId",
                table: "FilmAndFamousActors",
                column: "FamousActorId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndFamousActors_FilmId",
                table: "FilmAndFamousActors",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndLanguages_FilmId",
                table: "FilmAndLanguages",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmAndLanguages_LanguageId",
                table: "FilmAndLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_FilmCountryId",
                table: "Films",
                column: "FilmCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_IMDBId",
                table: "Films",
                column: "IMDBId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_ProductionYearId",
                table: "Films",
                column: "ProductionYearId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmAndCategories");

            migrationBuilder.DropTable(
                name: "FilmAndFamousActors");

            migrationBuilder.DropTable(
                name: "FilmAndLanguages");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "FamousActors");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "FilmCountries");

            migrationBuilder.DropTable(
                name: "IMDBs");

            migrationBuilder.DropTable(
                name: "ProductionYears");
        }
    }
}
