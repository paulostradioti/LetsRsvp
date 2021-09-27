using Microsoft.EntityFrameworkCore.Migrations;

namespace LetsRsvp.Migrations
{
    public partial class AdicionadoAcompnhante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acompanhante",
                table: "Confirmacoes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acompanhante",
                table: "Confirmacoes");
        }
    }
}
