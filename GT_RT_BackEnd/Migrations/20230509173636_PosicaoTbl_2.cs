using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class PosicaoTbl_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PosicoesPilotos",
                table: "ResultadoCorrida");

            migrationBuilder.AddColumn<int>(
                name: "Id_Posicao",
                table: "ResultadoCorrida",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Posicao",
                table: "ResultadoCorrida");

            migrationBuilder.AddColumn<string>(
                name: "PosicoesPilotos",
                table: "ResultadoCorrida",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
