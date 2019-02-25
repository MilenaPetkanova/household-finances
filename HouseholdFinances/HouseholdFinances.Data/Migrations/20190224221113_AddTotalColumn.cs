using Microsoft.EntityFrameworkCore.Migrations;

namespace HouseholdFinances.Data.Migrations
{
    public partial class AddTotalColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Capitals",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Capitals");
        }
    }
}
