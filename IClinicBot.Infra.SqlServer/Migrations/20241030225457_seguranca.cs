using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IClinicBot.Infra.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class seguranca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Pacientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Medicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Medicos");
        }
    }
}
