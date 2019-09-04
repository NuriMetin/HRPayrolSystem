using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class Worker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonus_AspNetUsers_WorkerId1",
                table: "Bonus");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerAbsens_AspNetUsers_WorkerId1",
                table: "WorkerAbsens");

            migrationBuilder.DropIndex(
                name: "IX_WorkerAbsens_WorkerId1",
                table: "WorkerAbsens");

            migrationBuilder.DropIndex(
                name: "IX_Bonus_WorkerId1",
                table: "Bonus");

            migrationBuilder.DropColumn(
                name: "WorkerId1",
                table: "WorkerAbsens");

            migrationBuilder.DropColumn(
                name: "WorkerId1",
                table: "Bonus");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "WorkerAbsens",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "Bonus",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_WorkerAbsens_WorkerId",
                table: "WorkerAbsens",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bonus_WorkerId",
                table: "Bonus",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonus_AspNetUsers_WorkerId",
                table: "Bonus",
                column: "WorkerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerAbsens_AspNetUsers_WorkerId",
                table: "WorkerAbsens",
                column: "WorkerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonus_AspNetUsers_WorkerId",
                table: "Bonus");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerAbsens_AspNetUsers_WorkerId",
                table: "WorkerAbsens");

            migrationBuilder.DropIndex(
                name: "IX_WorkerAbsens_WorkerId",
                table: "WorkerAbsens");

            migrationBuilder.DropIndex(
                name: "IX_Bonus_WorkerId",
                table: "Bonus");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "WorkerAbsens",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerId1",
                table: "WorkerAbsens",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "Bonus",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerId1",
                table: "Bonus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkerAbsens_WorkerId1",
                table: "WorkerAbsens",
                column: "WorkerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bonus_WorkerId1",
                table: "Bonus",
                column: "WorkerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonus_AspNetUsers_WorkerId1",
                table: "Bonus",
                column: "WorkerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerAbsens_AspNetUsers_WorkerId1",
                table: "WorkerAbsens",
                column: "WorkerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
