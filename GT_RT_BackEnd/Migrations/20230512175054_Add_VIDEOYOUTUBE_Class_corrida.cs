using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GT_RT_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class Add_VIDEOYOUTUBE_Class_corrida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoYoutube",
                table: "Corridas",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoYoutube",
                table: "Corridas");
        }
    }
}
