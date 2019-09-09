using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class workPlaceChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "WorkPlaces",
                newName: "WorkName");

            migrationBuilder.CreateTable(
                name: "WorkPlaceViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeId = table.Column<int>(nullable: false),
                    WorkName = table.Column<string>(nullable: true),
                    EnterDate = table.Column<DateTime>(nullable: false),
                    LeaveReason = table.Column<string>(nullable: true),
                    LeaveDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlaceViewModel", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkPlaceViewModel");

            migrationBuilder.RenameColumn(
                name: "WorkName",
                table: "WorkPlaces",
                newName: "Name");
        }
    }
}
