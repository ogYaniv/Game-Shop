using Microsoft.EntityFrameworkCore.Migrations;

namespace GameShop.Migrations
{
    public partial class search4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "Console");

            migrationBuilder.DropIndex(
                name: "IX_Product_ConsoleId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ConsoleId",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "ConsolePage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsolePage", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsolePage");

            migrationBuilder.AddColumn<int>(
                name: "ConsoleId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Console",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Console", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ConsoleId",
                table: "Product",
                column: "ConsoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product",
                column: "ConsoleId",
                principalTable: "Console",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
