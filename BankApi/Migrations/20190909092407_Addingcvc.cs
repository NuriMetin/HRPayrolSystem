using Microsoft.EntityFrameworkCore.Migrations;

namespace BankApi.Migrations
{
    public partial class Addingcvc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Holder",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "CVC",
                table: "Cards",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVC",
                table: "Cards");

            migrationBuilder.AddColumn<string>(
                name: "Holder",
                table: "Cards",
                nullable: true);
        }
    }
}
