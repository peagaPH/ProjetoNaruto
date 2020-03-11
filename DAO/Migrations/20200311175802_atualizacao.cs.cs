using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class atualizacaocs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gennin1 = table.Column<string>(nullable: true),
                    Gennin2 = table.Column<string>(nullable: true),
                    Gennin3 = table.Column<string>(nullable: true),
                    Jounnin = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Gennins",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Idade = table.Column<string>(nullable: true),
                    Cla = table.Column<int>(nullable: false),
                    Vilas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gennins", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Jounnins",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Vilas = table.Column<int>(nullable: false),
                    Cla = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jounnins", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipes");

            migrationBuilder.DropTable(
                name: "Gennins");

            migrationBuilder.DropTable(
                name: "Jounnins");
        }
    }
}
