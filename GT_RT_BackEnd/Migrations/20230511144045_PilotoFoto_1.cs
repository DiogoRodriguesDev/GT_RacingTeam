using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class PilotoFoto_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Foto",
                table: "Pilotos",
                type: "varbinary(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto",
                table: "Pilotos");
        }
    }
}
