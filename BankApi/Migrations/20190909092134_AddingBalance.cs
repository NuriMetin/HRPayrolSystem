using Microsoft.EntityFrameworkCore.Migrations;

namespace BankApi.Migrations
{
    public partial class AddingBalance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Balans",
                table: "Cards",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balans",
                table: "Cards");
        }
    }
}
