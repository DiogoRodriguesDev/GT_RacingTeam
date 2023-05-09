using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddResultadoCorridaTable_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResultadoCorrida",
                columns: table => new
                {
                    Id_ResultadoCorrida = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Id_piloto = table.Column<int>(type: "int", nullable: false),
                    Id_corrida = table.Column<int>(type: "int", nullable: false),
                    Tempo_total = table.Column<TimeSpan>(type: "time", nullable: false),
                    Pontos = table.Column<int>(type: "int", nullable: false),
                    PosicaoFinal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultadoCorrida", x => x.Id_ResultadoCorrida);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResultadoCorrida");
        }
    }
}
