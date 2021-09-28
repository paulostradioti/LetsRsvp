using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsRsvp.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Confirmacoes",
                table: "Confirmacoes");

            migrationBuilder.RenameTable(
                name: "Confirmacoes",
                newName: "MinhasConfirmacoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MinhasConfirmacoes",
                table: "MinhasConfirmacoes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MinhasConfirmacoes",
                table: "MinhasConfirmacoes");

            migrationBuilder.RenameTable(
                name: "MinhasConfirmacoes",
                newName: "Confirmacoes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Confirmacoes",
                table: "Confirmacoes",
                column: "Id");
        }
    }
}
