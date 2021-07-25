using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace controleCobranca.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "controleCobranca",
                schema: "dbo",
                columns: table => new
                {
                    indice = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cdContrato = table.Column<int>(type: "int", nullable: false),
                    nrTermo = table.Column<int>(type: "int", nullable: false),
                    lote = table.Column<int>(type: "int", nullable: false),
                    destinatario = table.Column<string>(type: "varchar(80)", nullable: false),
                    endereco = table.Column<string>(type: "varchar(120)", nullable: false),
                    numero = table.Column<string>(type: "varchar(10)", nullable: true),
                    complemento = table.Column<string>(type: "varchar(60)", nullable: false),
                    bairro = table.Column<string>(type: "varchar(30)", nullable: false),
                    cep = table.Column<string>(type: "varchar(15)", nullable: false),
                    cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    uf = table.Column<string>(type: "char(2)", nullable: false),
                    obs = table.Column<string>(type: "varchar(200)", nullable: false),
                    registroPlano = table.Column<string>(type: "varchar(60)", nullable: false),
                    dataEnvio = table.Column<DateTime>(type: "DateTime", nullable: false),
                    titulo = table.Column<string>(type: "varchar(40)", nullable: false),
                    vencimento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    valor = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_controleCobranca", x => x.indice);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "controleCobranca",
                schema: "dbo");
        }
    }
}
