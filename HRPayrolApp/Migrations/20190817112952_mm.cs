using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class mm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonus_AspNetUsers_WorkerId",
                table: "Bonus");

            migrationBuilder.DropIndex(
                name: "IX_Bonus_WorkerId",
                table: "Bonus");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonus_AspNetUsers_WorkerId1",
                table: "Bonus");

            migrationBuilder.DropIndex(
                name: "IX_Bonus_WorkerId1",
                table: "Bonus");

            migrationBuilder.DropColumn(
                name: "WorkerId1",
                table: "Bonus");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "Bonus",
                nullable: true,
                oldClrType: typeof(int));

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
        }
    }
}
