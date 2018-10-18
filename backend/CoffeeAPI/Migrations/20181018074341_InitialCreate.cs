using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeeAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Drinks");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Drinks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Drinks");

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Drinks",
                nullable: false,
                defaultValue: 0);
        }
    }
}
