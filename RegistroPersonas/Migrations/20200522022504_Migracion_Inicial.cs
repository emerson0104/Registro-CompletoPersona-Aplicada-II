using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistroPersonas.Migrations
{
    public partial class Migracion_Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdPersona = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(nullable: false),
                    Telefono = table.Column<string>(nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.IdPersona);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");
        }
    }
}
