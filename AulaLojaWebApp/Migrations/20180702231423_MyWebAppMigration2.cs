using Microsoft.EntityFrameworkCore.Migrations;

namespace AulaLojaWebApp.Migrations
{
    public partial class MyWebAppMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Pedidos_PedidoId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_PedidoId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "ItemPedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ItemPedidos_PedidoId",
                table: "ItemPedidos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemPedidos_Pedidos_PedidoId",
                table: "ItemPedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemPedidos_Pedidos_PedidoId",
                table: "ItemPedidos");

            migrationBuilder.DropIndex(
                name: "IX_ItemPedidos_PedidoId",
                table: "ItemPedidos");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "ItemPedidos");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PedidoId",
                table: "Pedidos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Pedidos_PedidoId",
                table: "Pedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
