using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class ChangedDismiss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkerDismisses_WorkerDisMissId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkerDisMissId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "WorkerDismisses");

            migrationBuilder.DropColumn(
                name: "WorkerDisMissId",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Reason",
                table: "WorkerDismisses",
                newName: "WorkerId1");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId1",
                table: "WorkerDismisses",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DismissId",
                table: "WorkerDismisses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkerId",
                table: "WorkerDismisses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dismisses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Reason = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dismisses", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerDismisses_DismissId",
                table: "WorkerDismisses",
                column: "DismissId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerDismisses_WorkerId1",
                table: "WorkerDismisses",
                column: "WorkerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerDismisses_Dismisses_DismissId",
                table: "WorkerDismisses",
                column: "DismissId",
                principalTable: "Dismisses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerDismisses_AspNetUsers_WorkerId1",
                table: "WorkerDismisses",
                column: "WorkerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerDismisses_Dismisses_DismissId",
                table: "WorkerDismisses");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerDismisses_AspNetUsers_WorkerId1",
                table: "WorkerDismisses");

            migrationBuilder.DropTable(
                name: "Dismisses");

            migrationBuilder.DropIndex(
                name: "IX_WorkerDismisses_DismissId",
                table: "WorkerDismisses");

            migrationBuilder.DropIndex(
                name: "IX_WorkerDismisses_WorkerId1",
                table: "WorkerDismisses");

            migrationBuilder.DropColumn(
                name: "DismissId",
                table: "WorkerDismisses");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "WorkerDismisses");

            migrationBuilder.RenameColumn(
                name: "WorkerId1",
                table: "WorkerDismisses",
                newName: "Reason");

            migrationBuilder.AlterColumn<string>(
                name: "Reason",
                table: "WorkerDismisses",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "WorkerDismisses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "WorkerDisMissId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkerDisMissId",
                table: "AspNetUsers",
                column: "WorkerDisMissId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkerDismisses_WorkerDisMissId",
                table: "AspNetUsers",
                column: "WorkerDisMissId",
                principalTable: "WorkerDismisses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
