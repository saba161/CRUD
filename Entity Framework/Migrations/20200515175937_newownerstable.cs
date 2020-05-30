using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity_Framework.Migrations
{
    public partial class newownerstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ownersid",
                table: "pets",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "owners",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_owners", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pets_Ownersid",
                table: "pets",
                column: "Ownersid");

            migrationBuilder.AddForeignKey(
                name: "FK_pets_owners_Ownersid",
                table: "pets",
                column: "Ownersid",
                principalTable: "owners",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pets_owners_Ownersid",
                table: "pets");

            migrationBuilder.DropTable(
                name: "owners");

            migrationBuilder.DropIndex(
                name: "IX_pets_Ownersid",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "Ownersid",
                table: "pets");
        }
    }
}
