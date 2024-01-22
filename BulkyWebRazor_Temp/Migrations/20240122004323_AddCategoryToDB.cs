using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BulkyWebRazor_Temp.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    intCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    strCategoryName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    intDisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.intCategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "intCategoryId", "intDisplayOrder", "strCategoryName" },
                values: new object[,]
                {
                    { 1, 1, "Anime" },
                    { 2, 2, "Action" },
                    { 3, 3, "Adventure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
