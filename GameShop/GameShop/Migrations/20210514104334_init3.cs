using Microsoft.EntityFrameworkCore.Migrations;

namespace GameShop.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConsoleId",
                table: "Console");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConsoleId",
                table: "Console",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
