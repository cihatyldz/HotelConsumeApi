using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DAL.Migrations
{
    public partial class InitialBookingchld : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChildCount",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildCount",
                table: "Bookings");
        }
    }
}
