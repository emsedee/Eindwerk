using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eindwerk.Data.Migrations
{
    public partial class usermerge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Emailadres",
                table: "Personeelsleden",
                newName: "UserName");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Personeelsleden",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Personeelsleden",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Personeelsleden",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Personeelsleden",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Personeelsleden",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Personeelsleden",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Personeelsleden",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Personeelsleden",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Personeelsleden",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "Personeelsleden",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Personeelsleden",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                table: "Personeelsleden",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Personeelsleden",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                table: "Personeelsleden");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Personeelsleden");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Personeelsleden",
                newName: "Emailadres");
        }
    }
}
