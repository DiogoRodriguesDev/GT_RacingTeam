﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class AddNomeCategoria_a_Competicao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome_Categoria",
                table: "Competicoes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome_Categoria",
                table: "Competicoes");
        }
    }
}
