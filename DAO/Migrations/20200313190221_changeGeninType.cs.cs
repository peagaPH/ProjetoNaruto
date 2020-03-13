using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class changeGeninTypecs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gennin1",
                table: "EQUIPES");

            migrationBuilder.DropColumn(
                name: "Gennin2",
                table: "EQUIPES");

            migrationBuilder.DropColumn(
                name: "Gennin3",
                table: "EQUIPES");

            migrationBuilder.DropColumn(
                name: "Jounnin",
                table: "EQUIPES");

            migrationBuilder.AddColumn<int>(
                name: "GenninID1",
                table: "EQUIPES",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenninID2",
                table: "EQUIPES",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenninID3",
                table: "EQUIPES",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JounninID",
                table: "EQUIPES",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "EQUIPES",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenninID1",
                table: "EQUIPES");

            migrationBuilder.DropColumn(
                name: "GenninID2",
                table: "EQUIPES");

            migrationBuilder.DropColumn(
                name: "GenninID3",
                table: "EQUIPES");

            migrationBuilder.DropColumn(
                name: "JounninID",
                table: "EQUIPES");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "EQUIPES");

            migrationBuilder.AddColumn<string>(
                name: "Gennin1",
                table: "EQUIPES",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gennin2",
                table: "EQUIPES",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gennin3",
                table: "EQUIPES",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Jounnin",
                table: "EQUIPES",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
