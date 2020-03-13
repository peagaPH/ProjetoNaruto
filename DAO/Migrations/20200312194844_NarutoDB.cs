using Microsoft.EntityFrameworkCore.Migrations;

namespace DAO.Migrations
{
    public partial class NarutoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Jounnins",
                table: "Jounnins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gennins",
                table: "Gennins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Equipes",
                table: "Equipes");

            migrationBuilder.RenameTable(
                name: "Jounnins",
                newName: "JOUNNINS");

            migrationBuilder.RenameTable(
                name: "Gennins",
                newName: "GENNINS");

            migrationBuilder.RenameTable(
                name: "Equipes",
                newName: "EQUIPES");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "JOUNNINS",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "GENNINS",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "GENNINS",
                unicode: false,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Jounnin",
                table: "EQUIPES",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gennin3",
                table: "EQUIPES",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gennin2",
                table: "EQUIPES",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Gennin1",
                table: "EQUIPES",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JOUNNINS",
                table: "JOUNNINS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GENNINS",
                table: "GENNINS",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EQUIPES",
                table: "EQUIPES",
                column: "ID");

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
                name: "KAGES");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JOUNNINS",
                table: "JOUNNINS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GENNINS",
                table: "GENNINS");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EQUIPES",
                table: "EQUIPES");

            migrationBuilder.RenameTable(
                name: "JOUNNINS",
                newName: "Jounnins");

            migrationBuilder.RenameTable(
                name: "GENNINS",
                newName: "Gennins");

            migrationBuilder.RenameTable(
                name: "EQUIPES",
                newName: "Equipes");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Jounnins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Gennins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Idade",
                table: "Gennins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Jounnin",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Gennin3",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Gennin2",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Gennin1",
                table: "Equipes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Jounnins",
                table: "Jounnins",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gennins",
                table: "Gennins",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Equipes",
                table: "Equipes",
                column: "ID");
        }
    }
}
