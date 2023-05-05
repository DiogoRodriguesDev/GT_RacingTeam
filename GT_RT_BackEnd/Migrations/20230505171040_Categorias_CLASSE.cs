using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Categorias_CLASSE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_Piloto_Categoria",
                table: "Pilotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Circuitos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Piloto_Categorias",
                columns: table => new
                {
                    Id_Piloto_Categorias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Piloto_Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piloto_Categorias", x => x.Id_Piloto_Categorias);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pilotos_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos",
                column: "Piloto_CategoriaId_Piloto_Categorias");

            migrationBuilder.AddForeignKey(
                name: "FK_Pilotos_Piloto_Categorias_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos",
                column: "Piloto_CategoriaId_Piloto_Categorias",
                principalTable: "Piloto_Categorias",
                principalColumn: "Id_Piloto_Categorias",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pilotos_Piloto_Categorias_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos");

            migrationBuilder.DropTable(
                name: "Piloto_Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Pilotos_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos");

            migrationBuilder.DropColumn(
                name: "Id_Piloto_Categoria",
                table: "Pilotos");

            migrationBuilder.DropColumn(
                name: "Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Circuitos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
