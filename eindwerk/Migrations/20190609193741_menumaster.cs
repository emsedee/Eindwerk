using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eindwerk.Migrations
{
    public partial class menumaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuMaster",
                columns: table => new
                {
                    MenuIdentity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MenuID = table.Column<string>(nullable: true),
                    MenuName = table.Column<string>(nullable: true),
                    Parent_MenuID = table.Column<string>(nullable: true),
                    User_Roll = table.Column<string>(nullable: true),
                    MenuFileName = table.Column<string>(nullable: true),
                    MenuURL = table.Column<string>(nullable: true),
                    USE_YN = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuMaster", x => x.MenuIdentity);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuMaster");
        }
    }
}
