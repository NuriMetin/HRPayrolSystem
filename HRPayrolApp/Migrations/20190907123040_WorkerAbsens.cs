using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class WorkerAbsens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BonusDate",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.CreateTable(
                name: "CompanyWorkPlaceAbsens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyWorkPlaceId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ExcusableAbsens = table.Column<int>(nullable: false),
                    UnExcusableAbsens = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CompanyWorkPlaceAbsens_CompanyWorkPlaceId",
                table: "CompanyWorkPlaceAbsens",
                column: "CompanyWorkPlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyWorkPlaceAbsens");

            migrationBuilder.AddColumn<DateTime>(
                name: "BonusDate",
                table: "CompanyWorkPlaceBonus",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "CompanyWorkPlaceBonus",
                nullable: false,
                defaultValue: "");
        }
    }
}
