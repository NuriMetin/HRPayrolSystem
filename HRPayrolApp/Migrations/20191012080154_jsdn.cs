using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class jsdn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Companies_CompanyID",
                table: "Stores");

            migrationBuilder.RenameColumn(
                name: "CompanyID",
                table: "Stores",
                newName: "CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_CompanyID",
                table: "Stores",
                newName: "IX_Stores_CompanyId");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "Stores",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Companies_CompanyId",
                table: "Stores",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stores_Companies_CompanyId",
                table: "Stores");

            migrationBuilder.RenameColumn(
                name: "CompanyId",
                table: "Stores",
                newName: "CompanyID");

            migrationBuilder.RenameIndex(
                name: "IX_Stores_CompanyId",
                table: "Stores",
                newName: "IX_Stores_CompanyID");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyID",
                table: "Stores",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Stores_Companies_CompanyID",
                table: "Stores",
                column: "CompanyID",
                principalTable: "Companies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
