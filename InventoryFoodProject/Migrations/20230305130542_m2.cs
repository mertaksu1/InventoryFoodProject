using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryFoodProject.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryDescription2",
                table: "Categories",
                newName: "CategoryDescriptionB");

            migrationBuilder.AddColumn<string>(
                name: "CategoryDescriptionA",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDescriptionA",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryDescriptionB",
                table: "Categories",
                newName: "CategoryDescription2");
        }
    }
}
