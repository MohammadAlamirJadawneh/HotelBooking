using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "HotelDescription", "HotelDiscount", "HotelImage", "HotelName", "HotelRank", "Hotelprice" },
                values: new object[] { 4, "Tala Bay is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ", 11.0, "Image3", "Dead Sea Hotel", 7.0, 65.0 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 6, "Dead Sea", 4 });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[] { 7, "Dead Sea", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelAddresses",
                keyColumn: "HotelAddressId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 4);
        }
    }
}
