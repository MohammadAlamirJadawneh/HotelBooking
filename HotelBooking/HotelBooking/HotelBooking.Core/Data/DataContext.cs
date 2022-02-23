using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelAddress> HotelAddresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Hotel>().HasData(
                   new Hotel
                   {
                       HotelId = 1,
                       HotelName = "movenpick",
                       HotelImage = "Image1",
                       Hotelprice = 35,
                       HotelDiscount = 3,
                       HotelDescription = "Stay at Mövenpick Hotel Amman to benefit from a great location, excellent food and wonderful Jordanian hospitality.  ",
                       HotelRank = 6

                   },
                       new Hotel
                       {
                           HotelId = 2,
                           HotelName = "Crowne Plaza",
                           HotelImage = "Image2",
                           Hotelprice = 45,
                           HotelDiscount = 9,
                           HotelDescription = "Stay at the Crowne Plaza Hotel Amman to take advantage of the great location, excellent food and wonderful Jordanian hospitality. ",
                           HotelRank = 7
                       }
                       ,
                       new Hotel
                       {
                           HotelId = 3,
                           HotelName = "talabay",
                           HotelImage = "Image3",
                           Hotelprice = 65,
                           HotelDiscount = 11,
                           HotelDescription = "Tala Bay is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ",
                           HotelRank = 7
                       }
                          ,
                       new Hotel
                       {
                           HotelId = 4,
                           HotelName = "Dead Sea Hotel",
                           HotelImage = "Image3",
                           Hotelprice = 65,
                           HotelDiscount = 11,
                           HotelDescription = "Tala Bay is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ",
                           HotelRank = 7
                       }

                   );
            modelBuilder.Entity<HotelAddress>().HasData(
                  new HotelAddress
                  {
                      HotelAddressId = 1,

                      HotelAddressCity = "Amman",

                      HotelId = 1


                  },
                new HotelAddress
                {
                    HotelAddressId = 2,

                    HotelAddressCity = "Aqaba",

                    HotelId = 1


                },

                new HotelAddress
                {
                    HotelAddressId = 3,
                    HotelAddressCity = "Dead Sea",

                    HotelId = 1


                }

                ,

                new HotelAddress
                {
                    HotelAddressId = 4,

                    HotelAddressCity = "Amman",

                    HotelId = 2


                },
                        new HotelAddress
                        {
                            HotelAddressId = 5,

                            HotelAddressCity = "Aqaba",

                            HotelId = 2


                        }  ,     new HotelAddress
                        {
                            HotelAddressId = 6,

                            HotelAddressCity = "Dead Sea",

                            HotelId = 4


                        }, new HotelAddress
                        {
                HotelAddressId = 7,

                            HotelAddressCity = "Dead Sea",

                            HotelId =3


                        }
                        , new HotelAddress
                        {
                            HotelAddressId =8,

                            HotelAddressCity = "Irbid",

                            HotelId = 3


                        }
                  );
        }

    }
}
