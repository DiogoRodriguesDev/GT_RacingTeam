using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Piloto_Equipa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Piloto_EquipaId",
                table: "Pilotos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pilotos_Piloto_EquipaId",
                table: "Pilotos",
                column: "Piloto_EquipaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pilotos_Equipas_Piloto_EquipaId",
                table: "Pilotos",
                column: "Piloto_EquipaId",
                principalTable: "Equipas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pilotos_Equipas_Piloto_EquipaId",
                table: "Pilotos");

            migrationBuilder.DropIndex(
                name: "IX_Pilotos_Piloto_EquipaId",
                table: "Pilotos");

            migrationBuilder.DropColumn(
                name: "Piloto_EquipaId",
                table: "Pilotos");
        }
    }
}
