using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PantryProApi.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUnusedPantryFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pantries_Categories_CategoryId",
                table: "Pantries");

            migrationBuilder.DropForeignKey(
                name: "FK_Pantries_Locations_LocationId",
                table: "Pantries");

            migrationBuilder.DropIndex(
                name: "IX_Pantries_CategoryId",
                table: "Pantries");

            migrationBuilder.DropIndex(
                name: "IX_Pantries_LocationId",
                table: "Pantries");

            migrationBuilder.DropColumn(
                name: "ExtraIntOne",
                table: "Pantries");

            migrationBuilder.DropColumn(
                name: "ExtraIntTwo",
                table: "Pantries");

            migrationBuilder.DropColumn(
                name: "ExtraStrOne",
                table: "Pantries");

            migrationBuilder.DropColumn(
                name: "ExtraStrTwo",
                table: "Pantries");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Pantries");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Pantries");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraIntOne",
                table: "Pantries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExtraIntTwo",
                table: "Pantries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraStrOne",
                table: "Pantries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExtraStrTwo",
                table: "Pantries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Pantries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Pantries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pantries_CategoryId",
                table: "Pantries",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pantries_LocationId",
                table: "Pantries",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pantries_Categories_CategoryId",
                table: "Pantries",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pantries_Locations_LocationId",
                table: "Pantries",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
