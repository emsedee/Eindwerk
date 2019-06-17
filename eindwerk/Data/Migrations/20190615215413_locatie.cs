using Microsoft.EntityFrameworkCore.Migrations;

namespace eindwerk.Data.Migrations
{
    public partial class locatie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VoorraadPlaatsen",
                table: "Locatie",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Oppervlakte",
                table: "Locatie",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Naam",
                table: "Locatie",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Naam",
                table: "Locatie");

            migrationBuilder.AlterColumn<string>(
                name: "VoorraadPlaatsen",
                table: "Locatie",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Oppervlakte",
                table: "Locatie",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 10);
        }
    }
}
