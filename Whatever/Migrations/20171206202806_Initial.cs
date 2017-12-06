using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Whatever.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstPlayerClass = table.Column<string>(nullable: false),
                    FirstPlayerEmail = table.Column<string>(nullable: false),
                    FirstPlayerName = table.Column<string>(nullable: false),
                    FirstPlayerPhoneNumber = table.Column<string>(nullable: true),
                    FirstPlayerSchool = table.Column<string>(nullable: false),
                    SecondPlayerClass = table.Column<string>(nullable: false),
                    SecondPlayerEmail = table.Column<string>(nullable: false),
                    SecondPlayerName = table.Column<string>(nullable: false),
                    SecondPlayerPhoneNumber = table.Column<string>(nullable: true),
                    SecondPlayerSchool = table.Column<string>(nullable: false),
                    TeamName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
