using Microsoft.EntityFrameworkCore.Migrations;

namespace GameShop.Migrations
{
    public partial class inity3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "ConsoleId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product",
                column: "ConsoleId",
                principalTable: "Console",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product");

            migrationBuilder.AlterColumn<int>(
                name: "ConsoleId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product",
                column: "ConsoleId",
                principalTable: "Console",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
