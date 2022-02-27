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
                       HotelImage = "https://cdn.audleytravel.com/700/-/79/154043075198089103191054060164068041221090238072.jpg",
                       Hotelprice = 35,
                       HotelDiscount = 3,
                       HotelDescription = "Stay at Mövenpick Hotel Amman to benefit from a great location, excellent food and wonderful Jordanian hospitality.  ",
                       HotelRank = 6

                   },
                   new Hotel
                   {
                       HotelId = 2,
                       HotelName = "Crowne Plaza",
                       HotelImage = "https://pix10.agoda.net/hotelImages/293/293138/293138_14040916380019019069.jpg",
                       Hotelprice = 45,
                       HotelDiscount = 9,
                       HotelDescription = "Stay at the Crowne Plaza Hotel Amman to take advantage of the great location, excellent food and wonderful Jordanian hospitality. ",
                       HotelRank = 7
                   }
                       ,
                   new Hotel
                   {
                       HotelId = 3,
                       HotelName = "Thousand Nights",
                       HotelImage = "https://imagesawe.s3.amazonaws.com/companies/images/2019/12/thousand_nights_hotel.jpg",
                       Hotelprice = 65,
                       HotelDiscount = 11,
                       HotelDescription = "Thousand Nights is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ",
                       HotelRank = 7
                   }
                          ,
                   new Hotel
                   {
                       HotelId = 4,
                       HotelName = "holiday inn",
                       HotelImage = "https://www.bridgetravel.com.jo/uploads/0000/15/2019/10/17/gallery-8-file-69.jpg",
                       Hotelprice = 77,
                       HotelDiscount = 12,
                       HotelDescription = "holiday inn is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ",
                       HotelRank = 7
                   },
                   new Hotel
                       {
                           HotelId =5,
                           HotelName = "intercontinental",
                           HotelImage = "https://media.cntraveler.com/photos/5440499858544c134c067b02/16:9/w_2560,c_limit/intercontinental-amman-jordan-exterior-rca-2014.jpg",
                           Hotelprice = 67,
                           HotelDiscount = 14,
                           HotelDescription = "An iconic landmark in bustling Amman, InterContinental Jordan Hotel offers cosmopolitan amenities with a Middle Eastern touch, from light-filled rooms, vibrant furnishings and sweeping architecture to international cuisines, Spa facilities, a selection of beautiful spaces suitable for different occasions, along with magnificent views. Located atop one of the seven hills of Amman, the hotel attracts international clientele from all over the world who enjoy its close proximity to the city center.",
                           HotelRank = 4
                       }
                   ,
                   new Hotel
                   {
                       HotelId =6,
                       HotelName = "Corp",
                       HotelImage = "https://media-cdn.tripadvisor.com/media/photo-s/10/8f/a3/4e/corp-amman-hotel.jpg",
                       Hotelprice = 79,
                       HotelDiscount = 22,
                       HotelDescription = "A stay at Corp Amman Hotel places you in the heart of Amman, within a 5-minute drive of The Specialty Hospital and Al Abdali Mall. This 4.5-star hotel is 1.6 mi (2.5 km) from The Boulevard and 2.2 mi (3.6 km) from Amman Citadel. Make yourself at home in one of the 108 air-conditioned rooms featuring minibars and LCD televisions. Complimentary wireless Internet access keeps you connected, and cable programming is available for your entertainment.",
                       HotelRank = 6
                   }
                   ,
                   new Hotel
                   {
                       HotelId = 7,
                       HotelName = "Kempinski ",
                       HotelImage = "http://fstravels.com/cp/pictures/hotels/top/453_Kempinski-Hotel-Amman-Jordan.JPG",   
                       Hotelprice = 49,
                       HotelDiscount = 9,
                       HotelDescription = "One of our top picks in Amman.This hotel is located in Shmeisani, Amman’s central business district. It features a 24-hour gym, a spa and 3 restaurants. The rooms offer panoramic Amman city views. The modern rooms at the Kempinski Hotel Amman have a seating area, a pillow menu and a marble bathroom with luxury amenities. Some rooms include a separate living area, an LCD TV and access to the Executive Lounge.",
                       HotelRank = 6
                   }
                   ,
                   new Hotel
                   {
                       HotelId = 8,
                       HotelName = "Grand Hyatt Amman  ",
                       HotelImage = "https://assets.hyatt.com/content/dam/hyatt/hyattdam/images/2017/08/14/1619/Grand-Hyatt-Amman-P207-Exterior-Night.jpg/Grand-Hyatt-Amman-P207-Exterior-Night.16x9.jpg",
                       Hotelprice = 49,
                       HotelDiscount = 9,
                       HotelDescription = "At the heart of the city, where modern and historic Amman meet, atop one of the city’s most prominent seven hills, Grand Hyatt Amman stands out with its distinctive carved pink stone façade, offering sweeping 360-degree views of the city. From welcoming guests and travelers into our expansive lobby, to not only capturing five-star comfort, but also an abundance of award-winning dining experiences, you will find all of this and more at Grand Hyatt Amman.",
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


                 },
                 new HotelAddress
                 {
                     HotelAddressId = 6,

                     HotelAddressCity = "Dead Sea",

                     HotelId = 4


                 },
                 new HotelAddress
                 {
                     HotelAddressId = 7,

                     HotelAddressCity = "Dead Sea",

                     HotelId = 3


                 }
                        ,
                 new HotelAddress
                 {
                     HotelAddressId = 8,

                     HotelAddressCity = "Irbid",

                     HotelId = 3


                 },new HotelAddress
                 {
                     HotelAddressId = 9,

                     HotelAddressCity = "Amman",

                     HotelId = 5


                 }, new HotelAddress
                 {
                     HotelAddressId = 10,

                     HotelAddressCity = "Aqaba",

                     HotelId = 5


                 }, new HotelAddress
                 {
                     HotelAddressId = 11,

                     HotelAddressCity = "Amman",

                     HotelId = 6


                 }, new HotelAddress
                 {
                     HotelAddressId = 12,

                     HotelAddressCity = "Irbid",

                     HotelId = 6


                 }, new HotelAddress
                 {
                     HotelAddressId = 13,

                     HotelAddressCity = "Dead Sea",

                     HotelId = 6


                 }, new HotelAddress
                 {
                     HotelAddressId = 14,

                     HotelAddressCity = "Amman",

                     HotelId = 7


                 }, new HotelAddress
                 {
                     HotelAddressId = 15,

                     HotelAddressCity = "Irbid",

                     HotelId = 7


                 }, new HotelAddress
                 {
                     HotelAddressId = 16,

                     HotelAddressCity = "Aqaba",

                     HotelId = 7


                 }, new HotelAddress
                 {
                     HotelAddressId = 17,

                     HotelAddressCity = "Amman",

                     HotelId = 8


                 }, new HotelAddress
                 {
                     HotelAddressId = 18,

                     HotelAddressCity = "Aqaba",

                     HotelId = 8


                 }
                  );
        }

    }
}
