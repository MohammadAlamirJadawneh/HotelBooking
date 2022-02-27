using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class sasw : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "HotelDescription", "HotelDiscount", "HotelImage", "HotelName", "HotelRank", "Hotelprice" },
                values: new object[] { 8, "https://assets.hyatt.com/content/dam/hyatt/hyattdam/images/2017/08/14/1619/Grand-Hyatt-Amman-P207-Exterior-Night.jpg/Grand-Hyatt-Amman-P207-Exterior-Night.16x9.jpg", 9.0, " ", "Grand Hyatt Amman  ", 7.0, 49.0 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 17, "Amman", 8 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 18, "Aqaba", 8 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8);
        }
    }
}
