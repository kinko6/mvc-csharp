using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcMalado.Migrations
{
    /// <inheritdoc />
    public partial class AddTurmaToAluno : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Turma",
                table: "Alunos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Turma",
                table: "Alunos");
        }
    }
}
