using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class AbsensChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcusableAbsens_Absens_AbsensId",
                table: "ExcusableAbsens");

            migrationBuilder.DropForeignKey(
                name: "FK_UnExcusableAbsens_Absens_AbsensId",
                table: "UnExcusableAbsens");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerAbsens_Absens_AbsensId",
                table: "WorkerAbsens");

            migrationBuilder.DropTable(
                name: "Absens");

            migrationBuilder.DropIndex(
                name: "IX_WorkerAbsens_AbsensId",
                table: "WorkerAbsens");

            migrationBuilder.DropColumn(
                name: "AbsensId",
                table: "WorkerAbsens");

            migrationBuilder.RenameColumn(
                name: "AbsensId",
                table: "UnExcusableAbsens",
                newName: "WorkerAbsensId");

            migrationBuilder.RenameIndex(
                name: "IX_UnExcusableAbsens_AbsensId",
                table: "UnExcusableAbsens",
                newName: "IX_UnExcusableAbsens_WorkerAbsensId");

            migrationBuilder.RenameColumn(
                name: "AbsensId",
                table: "ExcusableAbsens",
                newName: "WorkerAbsensId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcusableAbsens_AbsensId",
                table: "ExcusableAbsens",
                newName: "IX_ExcusableAbsens_WorkerAbsensId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WorkerAbsens",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CompanyWorkPlaceAbsensID",
                table: "UnExcusableAbsens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyWorkPlaceAbsensID",
                table: "ExcusableAbsens",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_UnExcusableAbsens_CompanyWorkPlaceAbsensID",
                table: "UnExcusableAbsens",
                column: "CompanyWorkPlaceAbsensID");

            migrationBuilder.CreateIndex(
                name: "IX_ExcusableAbsens_CompanyWorkPlaceAbsensID",
                table: "ExcusableAbsens",
                column: "CompanyWorkPlaceAbsensID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyWorkPlaceAbsens_CompanyWorkPlaceId",
                table: "CompanyWorkPlaceAbsens",
                column: "CompanyWorkPlaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcusableAbsens_CompanyWorkPlaceAbsens_CompanyWorkPlaceAbsensID",
                table: "ExcusableAbsens",
                column: "CompanyWorkPlaceAbsensID",
                principalTable: "CompanyWorkPlaceAbsens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExcusableAbsens_WorkerAbsens_WorkerAbsensId",
                table: "ExcusableAbsens",
                column: "WorkerAbsensId",
                principalTable: "WorkerAbsens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnExcusableAbsens_CompanyWorkPlaceAbsens_CompanyWorkPlaceAbsensID",
                table: "UnExcusableAbsens",
                column: "CompanyWorkPlaceAbsensID",
                principalTable: "CompanyWorkPlaceAbsens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UnExcusableAbsens_WorkerAbsens_WorkerAbsensId",
                table: "UnExcusableAbsens",
                column: "WorkerAbsensId",
                principalTable: "WorkerAbsens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExcusableAbsens_CompanyWorkPlaceAbsens_CompanyWorkPlaceAbsensID",
                table: "ExcusableAbsens");

            migrationBuilder.DropForeignKey(
                name: "FK_ExcusableAbsens_WorkerAbsens_WorkerAbsensId",
                table: "ExcusableAbsens");

            migrationBuilder.DropForeignKey(
                name: "FK_UnExcusableAbsens_CompanyWorkPlaceAbsens_CompanyWorkPlaceAbsensID",
                table: "UnExcusableAbsens");

            migrationBuilder.DropForeignKey(
                name: "FK_UnExcusableAbsens_WorkerAbsens_WorkerAbsensId",
                table: "UnExcusableAbsens");

            migrationBuilder.DropTable(
                name: "CompanyWorkPlaceAbsens");

            migrationBuilder.DropIndex(
                name: "IX_UnExcusableAbsens_CompanyWorkPlaceAbsensID",
                table: "UnExcusableAbsens");

            migrationBuilder.DropIndex(
                name: "IX_ExcusableAbsens_CompanyWorkPlaceAbsensID",
                table: "ExcusableAbsens");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WorkerAbsens");

            migrationBuilder.DropColumn(
                name: "CompanyWorkPlaceAbsensID",
                table: "UnExcusableAbsens");

            migrationBuilder.DropColumn(
                name: "CompanyWorkPlaceAbsensID",
                table: "ExcusableAbsens");

            migrationBuilder.RenameColumn(
                name: "WorkerAbsensId",
                table: "UnExcusableAbsens",
                newName: "AbsensId");

            migrationBuilder.RenameIndex(
                name: "IX_UnExcusableAbsens_WorkerAbsensId",
                table: "UnExcusableAbsens",
                newName: "IX_UnExcusableAbsens_AbsensId");

            migrationBuilder.RenameColumn(
                name: "WorkerAbsensId",
                table: "ExcusableAbsens",
                newName: "AbsensId");

            migrationBuilder.RenameIndex(
                name: "IX_ExcusableAbsens_WorkerAbsensId",
                table: "ExcusableAbsens",
                newName: "IX_ExcusableAbsens_AbsensId");

            migrationBuilder.AddColumn<int>(
                name: "AbsensId",
                table: "WorkerAbsens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Absens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absens", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerAbsens_AbsensId",
                table: "WorkerAbsens",
                column: "AbsensId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExcusableAbsens_Absens_AbsensId",
                table: "ExcusableAbsens",
                column: "AbsensId",
                principalTable: "Absens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UnExcusableAbsens_Absens_AbsensId",
                table: "UnExcusableAbsens",
                column: "AbsensId",
                principalTable: "Absens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerAbsens_Absens_AbsensId",
                table: "WorkerAbsens",
                column: "AbsensId",
                principalTable: "Absens",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
