using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePais = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Posiciones",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePosicion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiciones", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TiposNominas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreNomina = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposNominas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombreEquipo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFK = table.Column<string>(type: "varchar(3)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Paises_IdPaisFK",
                        column: x => x.IdPaisFK,
                        principalTable: "Paises",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NombrePersona = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Apellido = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdTipoNominaFK = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdEquipoFK = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Equipos_IdEquipoFK",
                        column: x => x.IdEquipoFK,
                        principalTable: "Equipos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personas_TiposNominas_IdTipoNominaFK",
                        column: x => x.IdTipoNominaFK,
                        principalTable: "TiposNominas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersonaFK = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Dorsal = table.Column<string>(type: "varchar(3)", maxLength: 3, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPosicionFK = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Personas_IdPersonaFK",
                        column: x => x.IdPersonaFK,
                        principalTable: "Personas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jugadores_Posiciones_IdPosicionFK",
                        column: x => x.IdPosicionFK,
                        principalTable: "Posiciones",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_IdPaisFK",
                table: "Equipos",
                column: "IdPaisFK");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_IdPersonaFK",
                table: "Jugadores",
                column: "IdPersonaFK",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_IdPosicionFK",
                table: "Jugadores",
                column: "IdPosicionFK");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdEquipoFK",
                table: "Personas",
                column: "IdEquipoFK");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_IdTipoNominaFK",
                table: "Personas",
                column: "IdTipoNominaFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Posiciones");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "TiposNominas");

            migrationBuilder.DropTable(
                name: "Paises");
        }
    }
}
