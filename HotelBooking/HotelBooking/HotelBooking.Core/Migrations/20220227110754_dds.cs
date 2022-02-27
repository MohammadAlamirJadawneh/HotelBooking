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
                values: new object[] { 10, "Aqaba", 5 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "HotelDescription", "HotelDiscount", "HotelImage", "HotelName", "HotelRank", "Hotelprice" },
                values: new object[] { 6, "A stay at Corp Amman Hotel places you in the heart of Amman, within a 5-minute drive of The Specialty Hospital and Al Abdali Mall. This 4.5-star hotel is 1.6 mi (2.5 km) from The Boulevard and 2.2 mi (3.6 km) from Amman Citadel. Make yourself at home in one of the 108 air-conditioned rooms featuring minibars and LCD televisions. Complimentary wireless Internet access keeps you connected, and cable programming is available for your entertainment.", 22.0, "https://media-cdn.tripadvisor.com/media/photo-s/10/8f/a3/4e/corp-amman-hotel.jpg", "Corp", 6.0, 79.0 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 11, "Amman", 6 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 12, "Irbid", 6 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 13, "Dead Sea", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 6);
        }
    }
}
