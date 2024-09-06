using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Commerce.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdateProductCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "SciFi");

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "Drama");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "id",
                keyValue: 2,
                column: "Name",
                value: "Actions");

            migrationBuilder.UpdateData(
                table: "ProductCategory",
                keyColumn: "id",
                keyValue: 3,
                column: "Name",
                value: "Actions");
        }
    }
}
