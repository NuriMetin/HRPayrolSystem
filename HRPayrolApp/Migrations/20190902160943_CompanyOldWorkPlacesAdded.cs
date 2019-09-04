using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class CompanyOldWorkPlacesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyWorkPlace_Employees_EmployeeID",
                table: "CompanyWorkPlace");

            migrationBuilder.RenameColumn(
                name: "EmployeeID",
                table: "CompanyWorkPlace",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyWorkPlace_EmployeeID",
                table: "CompanyWorkPlace",
                newName: "IX_CompanyWorkPlace_EmployeeId");

            migrationBuilder.AddColumn<int>(
                name: "CompanyWorkPlaceID",
                table: "WorkerDismisses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyWorkPlaceID",
                table: "OldWorkPlaces",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyWorkPlaceID",
                table: "Escapes",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "CompanyWorkPlace",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PassText",
                table: "CompanyWorkPlace",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "CompanyWorkPlace",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WorkerId",
                table: "CompanyWorkPlace",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompanyWorkPlaceID",
                table: "Bonus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkerDismisses_CompanyWorkPlaceID",
                table: "WorkerDismisses",
                column: "CompanyWorkPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_OldWorkPlaces_CompanyWorkPlaceID",
                table: "OldWorkPlaces",
                column: "CompanyWorkPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Escapes_CompanyWorkPlaceID",
                table: "Escapes",
                column: "CompanyWorkPlaceID");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyWorkPlace_PositionId",
                table: "CompanyWorkPlace",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Bonus_CompanyWorkPlaceID",
                table: "Bonus",
                column: "CompanyWorkPlaceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonus_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "Bonus",
                column: "CompanyWorkPlaceID",
                principalTable: "CompanyWorkPlace",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyWorkPlace_Employees_EmployeeId",
                table: "CompanyWorkPlace",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyWorkPlace_Positions_PositionId",
                table: "CompanyWorkPlace",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Escapes_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "Escapes",
                column: "CompanyWorkPlaceID",
                principalTable: "CompanyWorkPlace",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OldWorkPlaces_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "OldWorkPlaces",
                column: "CompanyWorkPlaceID",
                principalTable: "CompanyWorkPlace",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerDismisses_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "WorkerDismisses",
                column: "CompanyWorkPlaceID",
                principalTable: "CompanyWorkPlace",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonus_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "Bonus");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyWorkPlace_Employees_EmployeeId",
                table: "CompanyWorkPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_CompanyWorkPlace_Positions_PositionId",
                table: "CompanyWorkPlace");

            migrationBuilder.DropForeignKey(
                name: "FK_Escapes_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "Escapes");

            migrationBuilder.DropForeignKey(
                name: "FK_OldWorkPlaces_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "OldWorkPlaces");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkerDismisses_CompanyWorkPlace_CompanyWorkPlaceID",
                table: "WorkerDismisses");

            migrationBuilder.DropIndex(
                name: "IX_WorkerDismisses_CompanyWorkPlaceID",
                table: "WorkerDismisses");

            migrationBuilder.DropIndex(
                name: "IX_OldWorkPlaces_CompanyWorkPlaceID",
                table: "OldWorkPlaces");

            migrationBuilder.DropIndex(
                name: "IX_Escapes_CompanyWorkPlaceID",
                table: "Escapes");

            migrationBuilder.DropIndex(
                name: "IX_CompanyWorkPlace_PositionId",
                table: "CompanyWorkPlace");

            migrationBuilder.DropIndex(
                name: "IX_Bonus_CompanyWorkPlaceID",
                table: "Bonus");

            migrationBuilder.DropColumn(
                name: "CompanyWorkPlaceID",
                table: "WorkerDismisses");

            migrationBuilder.DropColumn(
                name: "CompanyWorkPlaceID",
                table: "OldWorkPlaces");

            migrationBuilder.DropColumn(
                name: "CompanyWorkPlaceID",
                table: "Escapes");

            migrationBuilder.DropColumn(
                name: "PassText",
                table: "CompanyWorkPlace");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "CompanyWorkPlace");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "CompanyWorkPlace");

            migrationBuilder.DropColumn(
                name: "CompanyWorkPlaceID",
                table: "Bonus");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "CompanyWorkPlace",
                newName: "EmployeeID");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyWorkPlace_EmployeeId",
                table: "CompanyWorkPlace",
                newName: "IX_CompanyWorkPlace_EmployeeID");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "CompanyWorkPlace",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyWorkPlace_Employees_EmployeeID",
                table: "CompanyWorkPlace",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
