using Microsoft.EntityFrameworkCore.Migrations;

namespace eindwerk.Data.Migrations
{
    public partial class @enum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dringend",
                table: "Prioriteit");

            migrationBuilder.DropColumn(
                name: "Gewoon",
                table: "Prioriteit");

            migrationBuilder.DropColumn(
                name: "Hoog Dringend",
                table: "Prioriteit");

            migrationBuilder.RenameColumn(
                name: "Zeer Dringen",
                table: "Prioriteit",
                newName: "_Prioriteit");

            migrationBuilder.AlterColumn<int>(
                name: "Soort interventie",
                table: "Interventies",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_Prioriteit",
                table: "Prioriteit",
                newName: "Zeer Dringen");

            migrationBuilder.AddColumn<string>(
                name: "Dringend",
                table: "Prioriteit",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gewoon",
                table: "Prioriteit",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hoog Dringend",
                table: "Prioriteit",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Soort interventie",
                table: "Interventies",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);
        }
    }
}
