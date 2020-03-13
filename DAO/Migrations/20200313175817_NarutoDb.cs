using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class NarutoDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EQUIPES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gennin1 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Gennin2 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Gennin3 = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Jounnin = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EQUIPES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GENNINS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Idade = table.Column<string>(unicode: false, nullable: true),
                    Cla = table.Column<int>(nullable: false),
                    Vilas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GENNINS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "JOUNNINS",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Vilas = table.Column<int>(nullable: false),
                    Cla = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOUNNINS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "KAGES",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Vilas = table.Column<int>(nullable: false),
                    Cla = table.Column<int>(nullable: false),
                    Senha = table.Column<string>(unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KAGES", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EQUIPES");

            migrationBuilder.DropTable(
                name: "GENNINS");

            migrationBuilder.DropTable(
                name: "JOUNNINS");

            migrationBuilder.DropTable(
                name: "KAGES");
        }
    }
}
