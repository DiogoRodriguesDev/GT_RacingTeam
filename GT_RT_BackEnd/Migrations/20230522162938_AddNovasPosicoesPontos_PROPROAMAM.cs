using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddNovasPosicoesPontos_PROPROAMAM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PosicaoNovosPontos_AM",
                columns: table => new
                {
                    Id_Posicao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_Posicao = table.Column<int>(type: "int", nullable: true),
                    Pontos_Da_Posicao = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosicaoNovosPontos_AM", x => x.Id_Posicao);
                });

            migrationBuilder.CreateTable(
                name: "PosicaoNovosPontos_PRO",
                columns: table => new
                {
                    Id_Posicao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_Posicao = table.Column<int>(type: "int", nullable: true),
                    Pontos_Da_Posicao = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosicaoNovosPontos_PRO", x => x.Id_Posicao);
                });

            migrationBuilder.CreateTable(
                name: "PosicaoNovosPontos_PROAM",
                columns: table => new
                {
                    Id_Posicao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero_Posicao = table.Column<int>(type: "int", nullable: true),
                    Pontos_Da_Posicao = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PosicaoNovosPontos_PROAM", x => x.Id_Posicao);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PosicaoNovosPontos_AM");

            migrationBuilder.DropTable(
                name: "PosicaoNovosPontos_PRO");

            migrationBuilder.DropTable(
                name: "PosicaoNovosPontos_PROAM");
        }
    }
}
