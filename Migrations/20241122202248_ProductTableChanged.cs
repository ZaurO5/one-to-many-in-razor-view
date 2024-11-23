using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Zay_Shop.Migrations
{
    /// <inheritdoc />
    public partial class ProductTableChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhotoPath",
                table: "Product",
                newName: "Photo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Photo",
                table: "Product",
                newName: "PhotoPath");
        }
    }
}
