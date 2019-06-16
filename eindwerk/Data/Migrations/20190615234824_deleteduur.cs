using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eindwerk.Data.Migrations
{
    public partial class deleteduur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "duur",
                table: "Interventies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "duur",
                table: "Interventies",
                type: "datetime",
                nullable: true);
        }
    }
}
