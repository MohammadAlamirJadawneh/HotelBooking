using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelBooking.Core.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelName = table.Column<string>(type: "varchar(50)", nullable: false),
                    HotelImage = table.Column<string>(type: "varchar(250)", nullable: false),
                    Hotelprice = table.Column<double>(type: "float", nullable: false),
                    HotelDiscount = table.Column<double>(type: "float", nullable: false),
                    HotelDescription = table.Column<string>(type: "varchar(Max)", nullable: false),
                    HotelRank = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.HotelId);
                });

            migrationBuilder.CreateTable(
                name: "HotelAddresses",
                columns: table => new
                {
                    HotelAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelAddressCity = table.Column<string>(type: "varchar(50)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAddresses", x => x.HotelAddressId);
                    table.ForeignKey(
                        name: "FK_HotelAddresses_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "HotelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "HotelDescription", "HotelDiscount", "HotelImage", "HotelName", "HotelRank", "Hotelprice" },
                values: new object[,]
                {
                    { 1, "Stay at Mövenpick Hotel Amman to benefit from a great location, excellent food and wonderful Jordanian hospitality.  ", 3.0, "https://cdn.audleytravel.com/700/-/79/154043075198089103191054060164068041221090238072.jpg", "movenpick", 6.0, 35.0 },
                    { 2, "Stay at the Crowne Plaza Hotel Amman to take advantage of the great location, excellent food and wonderful Jordanian hospitality. ", 9.0, "https://pix10.agoda.net/hotelImages/293/293138/293138_14040916380019019069.jpg", "Crowne Plaza", 7.0, 45.0 },
                    { 3, "Thousand Nights is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ", 11.0, "https://imagesawe.s3.amazonaws.com/companies/images/2019/12/thousand_nights_hotel.jpg", "Thousand Nights", 7.0, 65.0 },
                    { 4, "holiday inn is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ", 11.0, "https://www.bridgetravel.com.jo/uploads/0000/15/2019/10/17/gallery-8-file-69.jpg", "holiday inn", 7.0, 65.0 }
                });

            migrationBuilder.InsertData(
                table: "HotelAddresses",
                columns: new[] { "HotelAddressId", "HotelAddressCity", "HotelId" },
                values: new object[,]
                {
                    { 1, "Amman", 1 },
                    { 2, "Aqaba", 1 },
                    { 3, "Dead Sea", 1 },
                    { 4, "Amman", 2 },
                    { 5, "Aqaba", 2 },
                    { 7, "Dead Sea", 3 },
                    { 8, "Irbid", 3 },
                    { 6, "Dead Sea", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_HotelAddresses_HotelId",
                table: "HotelAddresses",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HotelAddresses");

            migrationBuilder.DropTable(
                name: "Hotels");
        }
    }
}
