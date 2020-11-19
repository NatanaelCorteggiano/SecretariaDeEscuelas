using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretariaDeEscuelas.Data.Migrations
{
    public partial class Maestros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarreraMateria_Carreras_CarreraId",
                table: "CarreraMateria");

            migrationBuilder.DropForeignKey(
                name: "FK_CarreraMateria_Materias_MateriaId",
                table: "CarreraMateria");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarreraMateria",
                table: "CarreraMateria");

            migrationBuilder.RenameTable(
                name: "CarreraMateria",
                newName: "CarrerasMaterias");

            migrationBuilder.RenameIndex(
                name: "IX_CarreraMateria_MateriaId",
                table: "CarrerasMaterias",
                newName: "IX_CarrerasMaterias_MateriaId");

            migrationBuilder.AddColumn<int>(
                name: "MaestroId",
                table: "Materias",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrerasMaterias",
                table: "CarrerasMaterias",
                columns: new[] { "CarreraId", "MateriaId" });

            migrationBuilder.CreateTable(
                name: "Maestros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maestros", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materias_MaestroId",
                table: "Materias",
                column: "MaestroId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrerasMaterias_Carreras_CarreraId",
                table: "CarrerasMaterias",
                column: "CarreraId",
                principalTable: "Carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarrerasMaterias_Materias_MateriaId",
                table: "CarrerasMaterias",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materias_Maestros_MaestroId",
                table: "Materias",
                column: "MaestroId",
                principalTable: "Maestros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrerasMaterias_Carreras_CarreraId",
                table: "CarrerasMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_CarrerasMaterias_Materias_MateriaId",
                table: "CarrerasMaterias");

            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Maestros_MaestroId",
                table: "Materias");

            migrationBuilder.DropTable(
                name: "Maestros");

            migrationBuilder.DropIndex(
                name: "IX_Materias_MaestroId",
                table: "Materias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrerasMaterias",
                table: "CarrerasMaterias");

            migrationBuilder.DropColumn(
                name: "MaestroId",
                table: "Materias");

            migrationBuilder.RenameTable(
                name: "CarrerasMaterias",
                newName: "CarreraMateria");

            migrationBuilder.RenameIndex(
                name: "IX_CarrerasMaterias_MateriaId",
                table: "CarreraMateria",
                newName: "IX_CarreraMateria_MateriaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarreraMateria",
                table: "CarreraMateria",
                columns: new[] { "CarreraId", "MateriaId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CarreraMateria_Carreras_CarreraId",
                table: "CarreraMateria",
                column: "CarreraId",
                principalTable: "Carreras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarreraMateria_Materias_MateriaId",
                table: "CarreraMateria",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
