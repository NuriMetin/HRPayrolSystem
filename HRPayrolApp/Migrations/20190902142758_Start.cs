using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRPayrolApp.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyWorkPlace",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyWorkPlace", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CompanyWorkPlace_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkerCompanyWorkPlace",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkerId = table.Column<string>(nullable: true),
                    CompanyWorkPlaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerCompanyWorkPlace", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkerCompanyWorkPlace_CompanyWorkPlace_CompanyWorkPlaceId",
                        column: x => x.CompanyWorkPlaceId,
                        principalTable: "CompanyWorkPlace",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerCompanyWorkPlace_AspNetUsers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyWorkPlace_EmployeeID",
                table: "CompanyWorkPlace",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerCompanyWorkPlace_CompanyWorkPlaceId",
                table: "WorkerCompanyWorkPlace",
                column: "CompanyWorkPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerCompanyWorkPlace_WorkerId",
                table: "WorkerCompanyWorkPlace",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkerCompanyWorkPlace");

            migrationBuilder.DropTable(
                name: "CompanyWorkPlace");
        }
    }
}
