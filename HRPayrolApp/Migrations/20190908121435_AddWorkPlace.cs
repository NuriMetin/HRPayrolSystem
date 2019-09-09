using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class AddWorkPlace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OldWorkPlaces");

            migrationBuilder.CreateTable(
                name: "WorkPlaces",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EnterDate = table.Column<DateTime>(nullable: false),
                    LeaveReason = table.Column<string>(nullable: true),
                    LeaveDate = table.Column<DateTime>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkPlaces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkPlaces_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkPlaces_EmployeeId",
                table: "WorkPlaces",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkPlaces");

            migrationBuilder.CreateTable(
                name: "OldWorkPlaces",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: true),
                    EnterDate = table.Column<DateTime>(nullable: false),
                    LeaveDate = table.Column<DateTime>(nullable: false),
                    LeaveReason = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    WorkerId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OldWorkPlaces", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OldWorkPlaces_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OldWorkPlaces_AspNetUsers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OldWorkPlaces_EmployeeID",
                table: "OldWorkPlaces",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_OldWorkPlaces_WorkerId",
                table: "OldWorkPlaces",
                column: "WorkerId");
        }
    }
}
