using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class ChangeDismiss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerDismisses_AspNetUsers_WorkerId1",
                table: "WorkerDismisses");

            migrationBuilder.DropIndex(
                name: "IX_WorkerDismisses_WorkerId1",
                table: "WorkerDismisses");

            migrationBuilder.DropColumn(
                name: "WorkerId1",
                table: "WorkerDismisses");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "WorkerDismisses",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_WorkerDismisses_WorkerId",
                table: "WorkerDismisses",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerDismisses_AspNetUsers_WorkerId",
                table: "WorkerDismisses",
                column: "WorkerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerDismisses_AspNetUsers_WorkerId",
                table: "WorkerDismisses");

            migrationBuilder.DropIndex(
                name: "IX_WorkerDismisses_WorkerId",
                table: "WorkerDismisses");

            migrationBuilder.AlterColumn<int>(
                name: "WorkerId",
                table: "WorkerDismisses",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerId1",
                table: "WorkerDismisses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkerDismisses_WorkerId1",
                table: "WorkerDismisses",
                column: "WorkerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerDismisses_AspNetUsers_WorkerId1",
                table: "WorkerDismisses",
                column: "WorkerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
