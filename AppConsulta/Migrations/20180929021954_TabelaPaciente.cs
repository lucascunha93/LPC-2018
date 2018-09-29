using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppConsulta.Migrations
{
    public partial class TabelaPaciente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(nullable: true),
                    endereco = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    nascimento = table.Column<int>(nullable: false),
                    tipo = table.Column<string>(nullable: true),
                    convenio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
