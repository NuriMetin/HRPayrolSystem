using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class CompanyWorkPlac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyWorkPlaceBonus_Bonus_BonusId",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerBonus_Bonus_BonusId",
                table: "WorkerBonus");

            migrationBuilder.DropTable(
                name: "Bonus");

            migrationBuilder.DropIndex(
                name: "IX_WorkerBonus_BonusId",
                table: "WorkerBonus");

            migrationBuilder.DropIndex(
                name: "IX_CompanyWorkPlaceBonus_BonusId",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.DropColumn(
                name: "BonusId",
                table: "WorkerBonus");

            migrationBuilder.DropColumn(
                name: "OldWorkPlaces",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "BonusId",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.AddColumn<DateTime>(
                name: "BonusDate",
                table: "WorkerBonus",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "BonusSalary",
                table: "WorkerBonus",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "WorkerBonus",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "OldWorkPlaces",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BonusDate",
                table: "CompanyWorkPlaceBonus",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "BonusSalary",
                table: "CompanyWorkPlaceBonus",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Reason",
                table: "CompanyWorkPlaceBonus",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_OldWorkPlaces_EmployeeID",
                table: "OldWorkPlaces",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_OldWorkPlaces_Employees_EmployeeID",
                table: "OldWorkPlaces",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OldWorkPlaces_Employees_EmployeeID",
                table: "OldWorkPlaces");

            migrationBuilder.DropIndex(
                name: "IX_OldWorkPlaces_EmployeeID",
                table: "OldWorkPlaces");

            migrationBuilder.DropColumn(
                name: "BonusDate",
                table: "WorkerBonus");

            migrationBuilder.DropColumn(
                name: "BonusSalary",
                table: "WorkerBonus");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "WorkerBonus");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "OldWorkPlaces");

            migrationBuilder.DropColumn(
                name: "BonusDate",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.DropColumn(
                name: "BonusSalary",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.DropColumn(
                name: "Reason",
                table: "CompanyWorkPlaceBonus");

            migrationBuilder.AddColumn<string>(
                name: "BonusId",
                table: "WorkerBonus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OldWorkPlaces",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BonusId",
                table: "CompanyWorkPlaceBonus",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Bonus",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    BonusDate = table.Column<DateTime>(nullable: false),
                    BonusSalary = table.Column<decimal>(nullable: false),
                    Reason = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonus", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerBonus_BonusId",
                table: "WorkerBonus",
                column: "BonusId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyWorkPlaceBonus_BonusId",
                table: "CompanyWorkPlaceBonus",
                column: "BonusId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyWorkPlaceBonus_Bonus_BonusId",
                table: "CompanyWorkPlaceBonus",
                column: "BonusId",
                principalTable: "Bonus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerBonus_Bonus_BonusId",
                table: "WorkerBonus",
                column: "BonusId",
                principalTable: "Bonus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
