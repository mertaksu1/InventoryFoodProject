using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryFoodProject.Migrations
{
    /// <inheritdoc />
    public partial class mert2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDescriptionA",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryDescriptionB",
                table: "Categories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryDescriptionA",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescriptionB",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
