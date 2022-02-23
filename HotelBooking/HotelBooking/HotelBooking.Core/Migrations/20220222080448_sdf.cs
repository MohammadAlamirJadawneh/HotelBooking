using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class sdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 7,
                column: "HotelId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 7,
                column: "HotelId",
                value: 4);
        }
    }
}
