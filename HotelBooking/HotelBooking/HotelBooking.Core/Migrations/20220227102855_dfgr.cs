using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class dfgr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "HotelDiscount", "Hotelprice" },
                values: new object[] { 12.0, 77.0 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "HotelDescription", "HotelDiscount", "HotelImage", "HotelName", "HotelRank", "Hotelprice" },
                values: new object[] { 5, "An iconic landmark in bustling Amman, InterContinental Jordan Hotel offers cosmopolitan amenities with a Middle Eastern touch, from light-filled rooms, vibrant furnishings and sweeping architecture to international cuisines, Spa facilities, a selection of beautiful spaces suitable for different occasions, along with magnificent views. Located atop one of the seven hills of Amman, the hotel attracts international clientele from all over the world who enjoy its close proximity to the city center.", 14.0, "https://media.cntraveler.com/photos/5440499858544c134c067b02/16:9/w_2560,c_limit/intercontinental-amman-jordan-exterior-rca-2014.jpg", "intercontinental", 4.0, 67.0 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 9, "Amman", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4,
                columns: new[] { "HotelDiscount", "Hotelprice" },
                values: new object[] { 11.0, 65.0 });
        }
    }
}
