using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class dds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 8, "Irbid", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 8);
        }
    }
}
