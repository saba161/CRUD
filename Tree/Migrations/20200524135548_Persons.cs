using Microsoft.EntityFrameworkCore.Migrations;

namespace Tree.Migrations
{
    public partial class Persons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Shop");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Shop",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Product",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Shop");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductName",
                table: "Product",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
