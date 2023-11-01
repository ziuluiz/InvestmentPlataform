using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvestmentPlataform.Server.Migrations
{
    /// <inheritdoc />
    public partial class cartItems2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsertId",
                table: "CartItems",
                newName: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CartItems",
                newName: "UsertId");
        }
    }
}
