using Microsoft.EntityFrameworkCore.Migrations;

namespace ClienteFornecedor.Migrations
{
    public partial class changeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdFornecedor",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "IdItens",
                table: "Pedido");

            migrationBuilder.AddColumn<long>(
                name: "ClienteIdCliente",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "FornecedorIdFornecedor",
                table: "Pedido",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ItensIdItens",
                table: "Pedido",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ClienteIdCliente",
                table: "Pedido",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_FornecedorIdFornecedor",
                table: "Pedido",
                column: "FornecedorIdFornecedor");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_ItensIdItens",
                table: "Pedido",
                column: "ItensIdItens");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteIdCliente",
                table: "Pedido",
                column: "ClienteIdCliente",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Fornecedor_FornecedorIdFornecedor",
                table: "Pedido",
                column: "FornecedorIdFornecedor",
                principalTable: "Fornecedor",
                principalColumn: "IdFornecedor",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Itens_ItensIdItens",
                table: "Pedido",
                column: "ItensIdItens",
                principalTable: "Itens",
                principalColumn: "IdItens",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteIdCliente",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Fornecedor_FornecedorIdFornecedor",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Itens_ItensIdItens",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ClienteIdCliente",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_FornecedorIdFornecedor",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_ItensIdItens",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "FornecedorIdFornecedor",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "ItensIdItens",
                table: "Pedido");

            migrationBuilder.AddColumn<long>(
                name: "IdCliente",
                table: "Pedido",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdFornecedor",
                table: "Pedido",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "IdItens",
                table: "Pedido",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
