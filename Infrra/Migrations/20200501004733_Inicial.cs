using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comandas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DtCriacao = table.Column<DateTime>(nullable: false),
                    DtAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Numero = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Aberta = table.Column<DateTime>(nullable: true),
                    Fechamento = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DtCriacao = table.Column<DateTime>(nullable: false),
                    DtAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    ComandaId = table.Column<Guid>(nullable: false),
                    Valor = table.Column<decimal>(nullable: false),
                    Garcon = table.Column<string>(nullable: true),
                    Mesa = table.Column<int>(nullable: false),
                    FormaPagamento = table.Column<int>(nullable: false),
                    Gorgeta = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Itens",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DtCriacao = table.Column<DateTime>(nullable: false),
                    DtAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Foto = table.Column<string>(nullable: true),
                    Disponivel = table.Column<short>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Itens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nota",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DtCriacao = table.Column<DateTime>(nullable: false),
                    DtAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Cpf = table.Column<long>(nullable: false),
                    ComandaId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nota", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nota_Comandas_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemComanda",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    DtCriacao = table.Column<DateTime>(nullable: false),
                    DtAlteracao = table.Column<DateTime>(nullable: true),
                    UsuarioCriacao = table.Column<string>(nullable: true),
                    UsuarioAlteracao = table.Column<string>(nullable: true),
                    ComandaId = table.Column<Guid>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemComanda", x => new { x.ComandaId, x.ItemId });
                    table.ForeignKey(
                        name: "FK_ItemComanda_Comandas_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemComanda_Itens_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Itens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Comandas",
                columns: new[] { "Id", "Aberta", "DtAlteracao", "DtCriacao", "Fechamento", "Nome", "Numero", "Status", "UsuarioAlteracao", "UsuarioCriacao" },
                values: new object[,]
                {
                    { new Guid("88bedef3-ef7a-47b7-ad92-030615908d23"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1000", 0, null, "EF" },
                    { new Guid("f5c402be-6a2e-4d82-923e-bc0b32b4fcda"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1010", 0, null, "EF" },
                    { new Guid("6e8bab14-a444-4862-8f10-e9cb447e7ad4"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1009", 0, null, "EF" },
                    { new Guid("a6afe3d2-67ed-4309-9f8d-4df806aa7106"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1007", 0, null, "EF" },
                    { new Guid("03fece18-1ce4-4fa2-8225-13e50191389b"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1006", 0, null, "EF" },
                    { new Guid("88ee7157-062d-4cd0-b2b0-a53f224fac1e"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1008", 0, null, "EF" },
                    { new Guid("2ac5722c-7d9c-4108-9176-d6f0d609002e"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1004", 0, null, "EF" },
                    { new Guid("d67ab492-751b-4343-aa01-282c93fd2794"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1003", 0, null, "EF" },
                    { new Guid("0c5ded1c-594c-4c4c-9cf1-8652c010197f"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1002", 0, null, "EF" },
                    { new Guid("ee4e6bb1-49e9-43e2-85d9-8a50c58a693b"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1001", 0, null, "EF" },
                    { new Guid("344722c0-0be6-4a05-bb11-eb66a1e96b1a"), null, null, new DateTime(2020, 4, 30, 21, 47, 33, 261, DateTimeKind.Local), null, null, "BDZ1005", 0, null, "EF" }
                });

            migrationBuilder.InsertData(
                table: "Itens",
                columns: new[] { "Id", "Descricao", "Disponivel", "DtAlteracao", "DtCriacao", "Foto", "Preco", "UsuarioAlteracao", "UsuarioCriacao" },
                values: new object[,]
                {
                    { new Guid("a8838f9f-81f8-4de4-839c-6dc1b1a3271c"), "Suco", (short)0, null, new DateTime(2020, 4, 30, 21, 47, 33, 260, DateTimeKind.Local), null, 5m, null, "EF" },
                    { new Guid("4e130d75-7885-429f-833e-82650c29777f"), "Cerveja", (short)0, null, new DateTime(2020, 4, 30, 21, 47, 33, 260, DateTimeKind.Local), null, 5m, null, "EF" },
                    { new Guid("945d9ea1-5830-487e-9fcd-12260418ef62"), "Vinho", (short)0, null, new DateTime(2020, 4, 30, 21, 47, 33, 260, DateTimeKind.Local), null, 25m, null, "EF" },
                    { new Guid("ac578104-0d93-459b-b276-0089f8614216"), "Porção Fritas", (short)0, null, new DateTime(2020, 4, 30, 21, 47, 33, 260, DateTimeKind.Local), null, 35m, null, "EF" },
                    { new Guid("c5d55d10-03f2-4242-805c-df07a2f7a3d1"), "Porção Pastel", (short)0, null, new DateTime(2020, 4, 30, 21, 47, 33, 260, DateTimeKind.Local), null, 45m, null, "EF" },
                    { new Guid("874c2ef1-812c-4f6b-bc76-58ced3a1eb4e"), "Água", (short)0, null, new DateTime(2020, 4, 30, 21, 47, 33, 260, DateTimeKind.Local), null, 5m, null, "EF" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItemComanda_ItemId",
                table: "ItemComanda",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Nota_ComandaId",
                table: "Nota",
                column: "ComandaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contas");

            migrationBuilder.DropTable(
                name: "ItemComanda");

            migrationBuilder.DropTable(
                name: "Nota");

            migrationBuilder.DropTable(
                name: "Itens");

            migrationBuilder.DropTable(
                name: "Comandas");
        }
    }
}
