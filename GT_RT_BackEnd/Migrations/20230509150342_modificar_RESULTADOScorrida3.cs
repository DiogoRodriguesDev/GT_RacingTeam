using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class modificar_RESULTADOScorrida3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ResultadoCorrida_Id_corrida",
                table: "ResultadoCorrida",
                column: "Id_corrida");

            migrationBuilder.CreateIndex(
                name: "IX_ResultadoCorrida_Id_piloto",
                table: "ResultadoCorrida",
                column: "Id_piloto");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultadoCorrida_Corridas_Id_corrida",
                table: "ResultadoCorrida",
                column: "Id_corrida",
                principalTable: "Corridas",
                principalColumn: "Id_corrida");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultadoCorrida_Pilotos_Id_piloto",
                table: "ResultadoCorrida",
                column: "Id_piloto",
                principalTable: "Pilotos",
                principalColumn: "Id_piloto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResultadoCorrida_Corridas_Id_corrida",
                table: "ResultadoCorrida");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultadoCorrida_Pilotos_Id_piloto",
                table: "ResultadoCorrida");

            migrationBuilder.DropIndex(
                name: "IX_ResultadoCorrida_Id_corrida",
                table: "ResultadoCorrida");

            migrationBuilder.DropIndex(
                name: "IX_ResultadoCorrida_Id_piloto",
                table: "ResultadoCorrida");
        }
    }
}
