using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sesion1.Domain.Migrations
{
    public partial class DbSesion1v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cellphone",
                table: "Developers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cellphone",
                table: "Developers");
        }
    }
}
