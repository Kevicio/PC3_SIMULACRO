using Microsoft.EntityFrameworkCore.Migrations;

namespace PC3_SIMULACRO.Migrations
{
    public partial class email_celular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "SolicitudesAdopcion",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SolicitudesAdopcion",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Celular",
                table: "SolicitudesAdopcion");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SolicitudesAdopcion");
        }
    }
}
