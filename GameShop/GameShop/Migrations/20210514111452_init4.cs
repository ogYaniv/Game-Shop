using Microsoft.EntityFrameworkCore.Migrations;

namespace GameShop.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Console_ConsoleId1",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Console_ConsoleId2",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ConsoleId1",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ConsoleId2",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ConsoleId1",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ConsoleId2",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ConsoleId1",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConsoleId2",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ConsoleId1",
                table: "Product",
                column: "ConsoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ConsoleId2",
                table: "Product",
                column: "ConsoleId2");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Console_ConsoleId",
                table: "Product",
                column: "ConsoleId",
                principalTable: "Console",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Console_ConsoleId1",
                table: "Product",
                column: "ConsoleId1",
                principalTable: "Console",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Console_ConsoleId2",
                table: "Product",
                column: "ConsoleId2",
                principalTable: "Console",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
