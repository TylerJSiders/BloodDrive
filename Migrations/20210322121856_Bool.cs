using Microsoft.EntityFrameworkCore.Migrations;

namespace BloodDriveDonation.Migrations
{
    public partial class Bool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Elligible",
                table: "Donators",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Elligible",
                table: "Donators");
        }
    }
}
