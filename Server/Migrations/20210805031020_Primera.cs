using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea9FormVacunate.Server.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cedula = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    nombre = table.Column<string>(type: "TEXT", nullable: false),
                    apellido = table.Column<string>(type: "TEXT", nullable: false),
                    telefono = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    tipo_sangre = table.Column<int>(type: "INTEGER", nullable: false),
                    provincia = table.Column<int>(type: "INTEGER", nullable: false),
                    direccion = table.Column<string>(type: "TEXT", nullable: false),
                    latitud = table.Column<string>(type: "TEXT", nullable: true),
                    longitud = table.Column<string>(type: "TEXT", nullable: true),
                    covid = table.Column<int>(type: "INTEGER", nullable: false),
                    justificacion = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solicitudes");
        }
    }
}
