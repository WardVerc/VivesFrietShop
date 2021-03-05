using Microsoft.EntityFrameworkCore.Migrations;

namespace Vives_FrietShop.Migrations
{
    public partial class AddedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "ShopItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopItems_OrderId",
                table: "ShopItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopItems_Orders_OrderId",
                table: "ShopItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopItems_Orders_OrderId",
                table: "ShopItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_ShopItems_OrderId",
                table: "ShopItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "ShopItems");
        }
    }
}
