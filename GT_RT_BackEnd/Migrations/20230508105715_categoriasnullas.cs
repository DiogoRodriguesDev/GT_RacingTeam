using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class categoriasnullas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pilotos_Piloto_Categorias_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos");

            migrationBuilder.AlterColumn<int>(
                name: "Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Piloto_Categoria",
                table: "Pilotos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pilotos_Piloto_Categorias_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos",
                column: "Piloto_CategoriaId_Piloto_Categorias",
                principalTable: "Piloto_Categorias",
                principalColumn: "Id_Piloto_Categorias");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pilotos_Piloto_Categorias_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos");

            migrationBuilder.AlterColumn<int>(
                name: "Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_Piloto_Categoria",
                table: "Pilotos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pilotos_Piloto_Categorias_Piloto_CategoriaId_Piloto_Categorias",
                table: "Pilotos",
                column: "Piloto_CategoriaId_Piloto_Categorias",
                principalTable: "Piloto_Categorias",
                principalColumn: "Id_Piloto_Categorias",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
