using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class Absensss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExcusableAbsens");

            migrationBuilder.DropTable(
                name: "UnExcusableAbsens");

            migrationBuilder.DropTable(
                name: "CompanyWorkPlaceAbsens");

            migrationBuilder.AddColumn<int>(
                name: "AbsensId",
                table: "WorkerAbsens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "WorkerAbsens",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkerAbsens_AbsensId",
                table: "WorkerAbsens",
                column: "AbsensId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerAbsens_Absens_AbsensId",
                table: "WorkerAbsens",
                column: "AbsensId",
                principalTable: "Absens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerAbsens_Absens_AbsensId",
                table: "WorkerAbsens");

            migrationBuilder.DropIndex(
                name: "IX_WorkerAbsens_AbsensId",
                table: "WorkerAbsens");

            migrationBuilder.DropColumn(
                name: "AbsensId",
                table: "WorkerAbsens");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "WorkerAbsens");

            migrationBuilder.CreateTable(
                name: "CompanyWorkPlaceAbsens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyWorkPlaceId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyWorkPlaceAbsens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompanyWorkPlaceAbsens_CompanyWorkPlaces_CompanyWorkPlaceId",
                        column: x => x.CompanyWorkPlaceId,
                        principalTable: "CompanyWorkPlaces",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExcusableAbsens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyWorkPlaceAbsensID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    WorkerAbsensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcusableAbsens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExcusableAbsens_CompanyWorkPlaceAbsens_CompanyWorkPlaceAbsensID",
                        column: x => x.CompanyWorkPlaceAbsensID,
                        principalTable: "CompanyWorkPlaceAbsens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExcusableAbsens_WorkerAbsens_WorkerAbsensId",
                        column: x => x.WorkerAbsensId,
                        principalTable: "WorkerAbsens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnExcusableAbsens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyWorkPlaceAbsensID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    WorkerAbsensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnExcusableAbsens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UnExcusableAbsens_CompanyWorkPlaceAbsens_CompanyWorkPlaceAbsensID",
                        column: x => x.CompanyWorkPlaceAbsensID,
                        principalTable: "CompanyWorkPlaceAbsens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UnExcusableAbsens_WorkerAbsens_WorkerAbsensId",
                        column: x => x.WorkerAbsensId,
                        principalTable: "WorkerAbsens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyWorkPlaceAbsens_CompanyWorkPlaceId",
                table: "CompanyWorkPlaceAbsens",
                column: "CompanyWorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_ExcusableAbsens_CompanyWorkPlaceAbsensID",
                table: "ExcusableAbsens",
                column: "CompanyWorkPlaceAbsensID");

            migrationBuilder.CreateIndex(
                name: "IX_ExcusableAbsens_WorkerAbsensId",
                table: "ExcusableAbsens",
                column: "WorkerAbsensId");

            migrationBuilder.CreateIndex(
                name: "IX_UnExcusableAbsens_CompanyWorkPlaceAbsensID",
                table: "UnExcusableAbsens",
                column: "CompanyWorkPlaceAbsensID");

            migrationBuilder.CreateIndex(
                name: "IX_UnExcusableAbsens_WorkerAbsensId",
                table: "UnExcusableAbsens",
                column: "WorkerAbsensId");
        }
    }
}
