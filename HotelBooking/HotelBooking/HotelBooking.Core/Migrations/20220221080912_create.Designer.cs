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
    [Migration("20220221080912_create")]
    partial class create
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
                        .HasColumnType("varchar(50)");

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
                            HotelImage = "Image1",
                            HotelName = "movenpick",
                            HotelRank = 6.0,
                            Hotelprice = 35.0
                        },
                        new
                        {
                            HotelId = 2,
                            HotelDescription = "Stay at the Crowne Plaza Hotel Amman to take advantage of the great location, excellent food and wonderful Jordanian hospitality. ",
                            HotelDiscount = 9.0,
                            HotelImage = "Image2",
                            HotelName = "Crowne Plaza",
                            HotelRank = 7.0,
                            Hotelprice = 45.0
                        },
                        new
                        {
                            HotelId = 3,
                            HotelDescription = "Tala Bay is planned to be fully self-sufficient from an infrastructure point of view, providing a diverse range of integrated services that span roads, electrical grids, ",
                            HotelDiscount = 11.0,
                            HotelImage = "Image3",
                            HotelName = "talabay",
                            HotelRank = 7.0,
                            Hotelprice = 65.0
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
