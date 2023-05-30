using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class pontosadicionarremover : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pontosAdicionar",
                table: "ResultadoCorrida",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "pontosRemover",
                table: "ResultadoCorrida",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pontosAdicionar",
                table: "ResultadoCorrida");

            migrationBuilder.DropColumn(
                name: "pontosRemover",
                table: "ResultadoCorrida");
        }
    }
}
