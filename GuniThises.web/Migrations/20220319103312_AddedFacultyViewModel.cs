using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuniThises.web.Migrations
{
    public partial class AddedFacultyViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FacultyViewModel",
                columns: table => new
                {
                    FacultyUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FacultyType = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyViewModel", x => x.FacultyUserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacultyViewModel");
        }
    }
}
