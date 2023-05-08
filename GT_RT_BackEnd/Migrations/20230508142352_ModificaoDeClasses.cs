using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class ModificaoDeClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corridas_Circuitos_CircuitoId",
                table: "Corridas");

            migrationBuilder.DropForeignKey(
                name: "FK_Corridas_Resultados_Id_Resultado",
                table: "Corridas");

            migrationBuilder.DropForeignKey(
                name: "FK_Resultados_Classificacoes_ClassificacaoGeralId_Pontuacao",
                table: "Resultados");

            migrationBuilder.DropForeignKey(
                name: "FK_Resultados_Pilotos_PilotoId_piloto",
                table: "Resultados");

            migrationBuilder.DropTable(
                name: "Carros");

            migrationBuilder.DropTable(
                name: "Circuitos");

            migrationBuilder.DropIndex(
                name: "IX_Corridas_CircuitoId",
                table: "Corridas");

            migrationBuilder.DropIndex(
                name: "IX_Corridas_Id_Resultado",
                table: "Corridas");

            migrationBuilder.DropColumn(
                name: "CircuitoId",
                table: "Corridas");

            migrationBuilder.DropColumn(
                name: "Id_circuito",
                table: "Corridas");

            migrationBuilder.AlterColumn<string>(
                name: "VoltaMaisRapida",
                table: "Resultados",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Posicao",
                table: "Resultados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PilotoId_piloto",
                table: "Resultados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Piloto",
                table: "Resultados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Corrida",
                table: "Resultados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClassificacaoGeralId_Pontuacao",
                table: "Resultados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroVoltas",
                table: "Corridas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "NumeroMinutos",
                table: "Corridas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_competicao",
                table: "Corridas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Resultado",
                table: "Corridas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Corridas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "CarrosPermitidos",
                table: "Corridas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Circuito",
                table: "Corridas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tipo_Pneus",
                table: "Corridas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Competicoes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Competicoes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Classificacao",
                table: "Classificacoes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Corridas_Id_Resultado",
                table: "Corridas",
                column: "Id_Resultado",
                unique: true,
                filter: "[Id_Resultado] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Corridas_Resultados_Id_Resultado",
                table: "Corridas",
                column: "Id_Resultado",
                principalTable: "Resultados",
                principalColumn: "Id_Resultado");

            migrationBuilder.AddForeignKey(
                name: "FK_Resultados_Classificacoes_ClassificacaoGeralId_Pontuacao",
                table: "Resultados",
                column: "ClassificacaoGeralId_Pontuacao",
                principalTable: "Classificacoes",
                principalColumn: "Id_Pontuacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Resultados_Pilotos_PilotoId_piloto",
                table: "Resultados",
                column: "PilotoId_piloto",
                principalTable: "Pilotos",
                principalColumn: "Id_piloto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corridas_Resultados_Id_Resultado",
                table: "Corridas");

            migrationBuilder.DropForeignKey(
                name: "FK_Resultados_Classificacoes_ClassificacaoGeralId_Pontuacao",
                table: "Resultados");

            migrationBuilder.DropForeignKey(
                name: "FK_Resultados_Pilotos_PilotoId_piloto",
                table: "Resultados");

            migrationBuilder.DropIndex(
                name: "IX_Corridas_Id_Resultado",
                table: "Corridas");

            migrationBuilder.DropColumn(
                name: "CarrosPermitidos",
                table: "Corridas");

            migrationBuilder.DropColumn(
                name: "Circuito",
                table: "Corridas");

            migrationBuilder.DropColumn(
                name: "Tipo_Pneus",
                table: "Corridas");

            migrationBuilder.AlterColumn<string>(
                name: "VoltaMaisRapida",
                table: "Resultados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Posicao",
                table: "Resultados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PilotoId_piloto",
                table: "Resultados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_Piloto",
                table: "Resultados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_Corrida",
                table: "Resultados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClassificacaoGeralId_Pontuacao",
                table: "Resultados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroVoltas",
                table: "Corridas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "NumeroMinutos",
                table: "Corridas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_competicao",
                table: "Corridas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id_Resultado",
                table: "Corridas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Data",
                table: "Corridas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CircuitoId",
                table: "Corridas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id_circuito",
                table: "Corridas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Competicoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Competicoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Classificacao",
                table: "Classificacoes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Carros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorridaId_corrida = table.Column<int>(type: "int", nullable: true),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carros_Corridas_CorridaId_corrida",
                        column: x => x.CorridaId_corrida,
                        principalTable: "Corridas",
                        principalColumn: "Id_corrida");
                });

            migrationBuilder.CreateTable(
                name: "Circuitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circuitos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Corridas_CircuitoId",
                table: "Corridas",
                column: "CircuitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Corridas_Id_Resultado",
                table: "Corridas",
                column: "Id_Resultado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carros_CorridaId_corrida",
                table: "Carros",
                column: "CorridaId_corrida");

            migrationBuilder.AddForeignKey(
                name: "FK_Corridas_Circuitos_CircuitoId",
                table: "Corridas",
                column: "CircuitoId",
                principalTable: "Circuitos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Corridas_Resultados_Id_Resultado",
                table: "Corridas",
                column: "Id_Resultado",
                principalTable: "Resultados",
                principalColumn: "Id_Resultado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resultados_Classificacoes_ClassificacaoGeralId_Pontuacao",
                table: "Resultados",
                column: "ClassificacaoGeralId_Pontuacao",
                principalTable: "Classificacoes",
                principalColumn: "Id_Pontuacao",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resultados_Pilotos_PilotoId_piloto",
                table: "Resultados",
                column: "PilotoId_piloto",
                principalTable: "Pilotos",
                principalColumn: "Id_piloto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
