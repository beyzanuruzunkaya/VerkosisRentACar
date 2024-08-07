using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VerkosisRentACar.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kilometre",
                table: "Araclar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Yıl",
                table: "Araclar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kilometre",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "Yıl",
                table: "Araclar");
        }
    }
}
