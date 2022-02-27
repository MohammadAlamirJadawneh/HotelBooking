﻿// <auto-generated />
using HotelBooking.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelBooking.Core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220227120158_sasw")]
    partial class sasw
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelBooking.Core.Data.Hotel", b =>
                {
                    b.Property<int>("HotelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HotelDescription")
                        .IsRequired()
                        .HasColumnType("varchar(Max)");

                    b.Property<double>("HotelDiscount")
                        .HasColumnType("float");

                    b.Property<string>("HotelImage")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("HotelName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<double>("HotelRank")
                        .HasColumnType("float");

                    b.Property<double>("Hotelprice")
                        .HasColumnType("float");

                    b.HasKey("HotelId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            HotelId = 1,
                            HotelDescription = "Stay at Mövenpick Hotel Amman to benefit from a great location, excellent food and wonderful Jordanian hospitality.  ",
                            HotelDiscount = 3.0,
                            HotelImage = "https://cdn.audleytravel.com/700/-/79/154043075198089103191054060164068041221090238072.jpg",
                            HotelName = "movenpick",
                            HotelRank = 6.0,
                            Hotelprice = 35.0
                        },
                        new
                        {
                            HotelId = 2,
                            HotelDescription = "Stay at the Crowne Plaza Hotel Amman to take advantage of the great location, excellent food and wonderful Jordanian hospitality. ",
                            HotelDiscount = 9.0,
                            HotelImage = "https://pix10.agoda.net/hotelImages/293/293138/293138_14040916380019019069.jpg",
                            HotelName = "Crowne Plaza",
                            HotelRank = 7.0,
                            Hotelprice = 45.0
                        },
                        new
                        {
                            HotelId = 3,
                            HotelDescription = "Thousand Nights is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ",
                            HotelDiscount = 11.0,
                            HotelImage = "https://imagesawe.s3.amazonaws.com/companies/images/2019/12/thousand_nights_hotel.jpg",
                            HotelName = "Thousand Nights",
                            HotelRank = 7.0,
                            Hotelprice = 65.0
                        },
                        new
                        {
                            HotelId = 4,
                            HotelDescription = "holiday inn is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ",
                            HotelDiscount = 12.0,
                            HotelImage = "https://www.bridgetravel.com.jo/uploads/0000/15/2019/10/17/gallery-8-file-69.jpg",
                            HotelName = "holiday inn",
                            HotelRank = 7.0,
                            Hotelprice = 77.0
                        },
                        new
                        {
                            HotelId = 5,
                            HotelDescription = "An iconic landmark in bustling Amman, InterContinental Jordan Hotel offers cosmopolitan amenities with a Middle Eastern touch, from light-filled rooms, vibrant furnishings and sweeping architecture to international cuisines, Spa facilities, a selection of beautiful spaces suitable for different occasions, along with magnificent views. Located atop one of the seven hills of Amman, the hotel attracts international clientele from all over the world who enjoy its close proximity to the city center.",
                            HotelDiscount = 14.0,
                            HotelImage = "https://media.cntraveler.com/photos/5440499858544c134c067b02/16:9/w_2560,c_limit/intercontinental-amman-jordan-exterior-rca-2014.jpg",
                            HotelName = "intercontinental",
                            HotelRank = 4.0,
                            Hotelprice = 67.0
                        },
                        new
                        {
                            HotelId = 6,
                            HotelDescription = "A stay at Corp Amman Hotel places you in the heart of Amman, within a 5-minute drive of The Specialty Hospital and Al Abdali Mall. This 4.5-star hotel is 1.6 mi (2.5 km) from The Boulevard and 2.2 mi (3.6 km) from Amman Citadel. Make yourself at home in one of the 108 air-conditioned rooms featuring minibars and LCD televisions. Complimentary wireless Internet access keeps you connected, and cable programming is available for your entertainment.",
                            HotelDiscount = 22.0,
                            HotelImage = "https://media-cdn.tripadvisor.com/media/photo-s/10/8f/a3/4e/corp-amman-hotel.jpg",
                            HotelName = "Corp",
                            HotelRank = 6.0,
                            Hotelprice = 79.0
                        },
                        new
                        {
                            HotelId = 7,
                            HotelDescription = "One of our top picks in Amman.This hotel is located in Shmeisani, Amman’s central business district. It features a 24-hour gym, a spa and 3 restaurants. The rooms offer panoramic Amman city views. The modern rooms at the Kempinski Hotel Amman have a seating area, a pillow menu and a marble bathroom with luxury amenities. Some rooms include a separate living area, an LCD TV and access to the Executive Lounge.",
                            HotelDiscount = 9.0,
                            HotelImage = "http://fstravels.com/cp/pictures/hotels/top/453_Kempinski-Hotel-Amman-Jordan.JPG",
                            HotelName = "Kempinski ",
                            HotelRank = 6.0,
                            Hotelprice = 49.0
                        },
                        new
                        {
                            HotelId = 8,
                            HotelDescription = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/114318086.jpg",
                            HotelDiscount = 9.0,
                            HotelImage = " ",
                            HotelName = "Grand Hyatt Amman  ",
                            HotelRank = 7.0,
                            Hotelprice = 49.0
                        });
                });

            modelBuilder.Entity("HotelBooking.Core.Data.HotelAddress", b =>
                {
                    b.Property<int>("HotelAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HotelAddressCity")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.HasKey("HotelAddressId");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelAddresses");

                    b.HasData(
                        new
                        {
                            HotelAddressId = 1,
                            HotelAddressCity = "Amman",
                            HotelId = 1
                        },
                        new
                        {
                            HotelAddressId = 2,
                            HotelAddressCity = "Aqaba",
                            HotelId = 1
                        },
                        new
                        {
                            HotelAddressId = 3,
                            HotelAddressCity = "Dead Sea",
                            HotelId = 1
                        },
                        new
                        {
                            HotelAddressId = 4,
                            HotelAddressCity = "Amman",
                            HotelId = 2
                        },
                        new
                        {
                            HotelAddressId = 5,
                            HotelAddressCity = "Aqaba",
                            HotelId = 2
                        },
                        new
                        {
                            HotelAddressId = 6,
                            HotelAddressCity = "Dead Sea",
                            HotelId = 4
                        },
                        new
                        {
                            HotelAddressId = 7,
                            HotelAddressCity = "Dead Sea",
                            HotelId = 3
                        },
                        new
                        {
                            HotelAddressId = 8,
                            HotelAddressCity = "Irbid",
                            HotelId = 3
                        },
                        new
                        {
                            HotelAddressId = 9,
                            HotelAddressCity = "Amman",
                            HotelId = 5
                        },
                        new
                        {
                            HotelAddressId = 10,
                            HotelAddressCity = "Aqaba",
                            HotelId = 5
                        },
                        new
                        {
                            HotelAddressId = 11,
                            HotelAddressCity = "Amman",
                            HotelId = 6
                        },
                        new
                        {
                            HotelAddressId = 12,
                            HotelAddressCity = "Irbid",
                            HotelId = 6
                        },
                        new
                        {
                            HotelAddressId = 13,
                            HotelAddressCity = "Dead Sea",
                            HotelId = 6
                        },
                        new
                        {
                            HotelAddressId = 14,
                            HotelAddressCity = "Amman",
                            HotelId = 7
                        },
                        new
                        {
                            HotelAddressId = 15,
                            HotelAddressCity = "Irbid",
                            HotelId = 7
                        },
                        new
                        {
                            HotelAddressId = 16,
                            HotelAddressCity = "Aqaba",
                            HotelId = 7
                        },
                        new
                        {
                            HotelAddressId = 17,
                            HotelAddressCity = "Amman",
                            HotelId = 8
                        },
                        new
                        {
                            HotelAddressId = 18,
                            HotelAddressCity = "Aqaba",
                            HotelId = 8
                        });
                });

            modelBuilder.Entity("HotelBooking.Core.Data.HotelAddress", b =>
                {
                    b.HasOne("HotelBooking.Core.Data.Hotel", "Hotel")
                        .WithMany("HotelAddresses")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("HotelBooking.Core.Data.Hotel", b =>
                {
                    b.Navigation("HotelAddresses");
                });
#pragma warning restore 612, 618
        }
    }
}
