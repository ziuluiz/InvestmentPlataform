using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvestmentPlataform.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "desc1", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c4/Eo_circle_red_number-1.svg/800px-Eo_circle_red_number-1.svg.png", 9.11m, "teste11" },
                    { 2, "desc2", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/61/NYCS-bull-trans-2.svg/1200px-NYCS-bull-trans-2.svg.png", 9.22m, "teste2" },
                    { 3, "desc3", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/NYCS-bull-trans-3.svg/1200px-NYCS-bull-trans-3.svg.png", 9.33m, "teste3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
