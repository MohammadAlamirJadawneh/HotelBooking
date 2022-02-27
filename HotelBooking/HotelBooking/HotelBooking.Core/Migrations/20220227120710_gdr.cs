using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class gdr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "HotelDescription", "HotelImage" },
                values: new object[] { "At the heart of the city, where modern and historic Amman meet, atop one of the city’s most prominent seven hills, Grand Hyatt Amman stands out with its distinctive carved pink stone façade, offering sweeping 360-degree views of the city. From welcoming guests and travelers into our expansive lobby, to not only capturing five-star comfort, but also an abundance of award-winning dining experiences, you will find all of this and more at Grand Hyatt Amman.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/114318086.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: 8,
                columns: new[] { "HotelDescription", "HotelImage" },
                values: new object[] { "https://cf.bstatic.com/xdata/images/hotel/max1024x768/114318086.jpg", " " });
        }
    }
}
