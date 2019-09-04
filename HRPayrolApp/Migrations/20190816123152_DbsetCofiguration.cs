using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class DbsetCofiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OldWorkPlace_AspNetUsers_WorkerId",
                table: "OldWorkPlace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OldWorkPlace",
                table: "OldWorkPlace");

            migrationBuilder.RenameTable(
                name: "OldWorkPlace",
                newName: "OldWorkPlaces");

            migrationBuilder.RenameIndex(
                name: "IX_OldWorkPlace_WorkerId",
                table: "OldWorkPlaces",
                newName: "IX_OldWorkPlaces_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OldWorkPlaces",
                table: "OldWorkPlaces",
                column: "ID");

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

            migrationBuilder.CreateTable(
                name: "ExcusableAbsens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AbsensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExcusableAbsens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ExcusableAbsens_Absens_AbsensId",
                        column: x => x.AbsensId,
                        principalTable: "Absens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnExcusableAbsens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    AbsensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnExcusableAbsens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UnExcusableAbsens_Absens_AbsensId",
                        column: x => x.AbsensId,
                        principalTable: "Absens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkerAbsens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkerId = table.Column<int>(nullable: false),
                    WorkerId1 = table.Column<string>(nullable: true),
                    AbsensId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerAbsens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkerAbsens_Absens_AbsensId",
                        column: x => x.AbsensId,
                        principalTable: "Absens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerAbsens_AspNetUsers_WorkerId1",
                        column: x => x.WorkerId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExcusableAbsens_AbsensId",
                table: "ExcusableAbsens",
                column: "AbsensId");

            migrationBuilder.CreateIndex(
                name: "IX_UnExcusableAbsens_AbsensId",
                table: "UnExcusableAbsens",
                column: "AbsensId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerAbsens_AbsensId",
                table: "WorkerAbsens",
                column: "AbsensId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerAbsens_WorkerId1",
                table: "WorkerAbsens",
                column: "WorkerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OldWorkPlaces_AspNetUsers_WorkerId",
                table: "OldWorkPlaces",
                column: "WorkerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OldWorkPlaces_AspNetUsers_WorkerId",
                table: "OldWorkPlaces");

            migrationBuilder.DropTable(
                name: "ExcusableAbsens");

            migrationBuilder.DropTable(
                name: "UnExcusableAbsens");

            migrationBuilder.DropTable(
                name: "WorkerAbsens");

            migrationBuilder.DropTable(
                name: "Absens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OldWorkPlaces",
                table: "OldWorkPlaces");

            migrationBuilder.RenameTable(
                name: "OldWorkPlaces",
                newName: "OldWorkPlace");

            migrationBuilder.RenameIndex(
                name: "IX_OldWorkPlaces_WorkerId",
                table: "OldWorkPlace",
                newName: "IX_OldWorkPlace_WorkerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OldWorkPlace",
                table: "OldWorkPlace",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_OldWorkPlace_AspNetUsers_WorkerId",
                table: "OldWorkPlace",
                column: "WorkerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
