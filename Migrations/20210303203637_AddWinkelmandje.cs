using Microsoft.EntityFrameworkCore.Migrations;

namespace Vives_FrietShop.Migrations
{
    public partial class AddWinkelmandje : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItems",
                table: "ShopItems");

            migrationBuilder.RenameTable(
                name: "ShopItems",
                newName: "ShopItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItem",
                table: "ShopItem",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopItem",
                table: "ShopItem");

            migrationBuilder.RenameTable(
                name: "ShopItem",
                newName: "ShopItems");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopItems",
                table: "ShopItems",
                column: "Id");
        }
    }
}
