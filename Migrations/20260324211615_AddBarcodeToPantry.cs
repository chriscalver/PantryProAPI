using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PantryProApi.Migrations
{
    /// <inheritdoc />
    public partial class AddBarcodeToPantry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "Pantries",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "Pantries");
        }
    }
}
