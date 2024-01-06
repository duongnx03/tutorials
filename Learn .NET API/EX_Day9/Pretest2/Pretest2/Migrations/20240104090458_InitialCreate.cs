using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pretest2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbNews",
                columns: table => new
                {
                    NewsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NewsContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfPublish = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbNews", x => x.NewsId);
                });

            migrationBuilder.InsertData(
                table: "tbNews",
                columns: new[] { "NewsId", "DateOfPublish", "NewsContent" },
                values: new object[,]
                {
                    { "new1", "4/1/2024", "ncc" },
                    { "new2", "5/1/2024", "ndb" },
                    { "new3", "6/1/2024", "dmm" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbNews");
        }
    }
}
