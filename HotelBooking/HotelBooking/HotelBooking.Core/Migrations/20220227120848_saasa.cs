using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class saasa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8,
                column: "HotelImage",
                value: "https://assets.hyatt.com/content/dam/hyatt/hyattdam/images/2017/08/14/1619/Grand-Hyatt-Amman-P207-Exterior-Night.jpg/Grand-Hyatt-Amman-P207-Exterior-Night.16x9.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8,
                column: "HotelImage",
                value: "https://cf.bstatic.com/xdata/images/hotel/max1024x768/114318086.jpg");
        }
    }
}
