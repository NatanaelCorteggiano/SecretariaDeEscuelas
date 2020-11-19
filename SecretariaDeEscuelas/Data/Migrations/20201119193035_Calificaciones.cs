using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SecretariaDeEscuelas.Data.Migrations
{
    public partial class Calificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriasEstudiantes",
                table: "MateriasEstudiantes");

            migrationBuilder.AddColumn<int>(
                name: "CalificacionId",
                table: "MateriasEstudiantes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriasEstudiantes",
                table: "MateriasEstudiantes",
                columns: new[] { "MateriaId", "EstudianteId", "CalificacionId" });

            migrationBuilder.CreateTable(
                name: "Calificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nota = table.Column<double>(nullable: false),
                    EstudianteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calificaciones_Estudiantes_EstudianteId",
                        column: x => x.EstudianteId,
                        principalTable: "Estudiantes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MateriasEstudiantes_CalificacionId",
                table: "MateriasEstudiantes",
                column: "CalificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Calificaciones_EstudianteId",
                table: "Calificaciones",
                column: "EstudianteId");

            migrationBuilder.AddForeignKey(
                name: "FK_MateriasEstudiantes_Calificaciones_CalificacionId",
                table: "MateriasEstudiantes",
                column: "CalificacionId",
                principalTable: "Calificaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MateriasEstudiantes_Calificaciones_CalificacionId",
                table: "MateriasEstudiantes");

            migrationBuilder.DropTable(
                name: "Calificaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MateriasEstudiantes",
                table: "MateriasEstudiantes");

            migrationBuilder.DropIndex(
                name: "IX_MateriasEstudiantes_CalificacionId",
                table: "MateriasEstudiantes");

            migrationBuilder.DropColumn(
                name: "CalificacionId",
                table: "MateriasEstudiantes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MateriasEstudiantes",
                table: "MateriasEstudiantes",
                columns: new[] { "MateriaId", "EstudianteId" });
        }
    }
}
