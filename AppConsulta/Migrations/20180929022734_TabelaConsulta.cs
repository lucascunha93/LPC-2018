using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppConsulta.Migrations
{
    public partial class TabelaConsulta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pacienteid = table.Column<int>(nullable: true),
                    hraConsulta = table.Column<DateTime>(nullable: false),
                    tipo = table.Column<string>(nullable: true),
                    valor = table.Column<int>(nullable: false),
                    hrFinal = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.id);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_pacienteid",
                        column: x => x.pacienteid,
                        principalTable: "Pacientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_pacienteid",
                table: "Consultas",
                column: "pacienteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");
        }
    }
}
