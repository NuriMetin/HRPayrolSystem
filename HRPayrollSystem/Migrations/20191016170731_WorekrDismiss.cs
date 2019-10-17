using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrollSystem.Migrations
{
    public partial class WorekrDismiss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AbsensCount",
                table: "WorkerAbsens",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbsensCount",
                table: "WorkerAbsens");
        }
    }
}
