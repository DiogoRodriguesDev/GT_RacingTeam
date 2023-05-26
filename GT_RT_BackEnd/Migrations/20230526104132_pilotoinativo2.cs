using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class pilotoinativo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Inativo",
                table: "Pilotos",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Inativo",
                table: "Pilotos");
        }
    }
}
