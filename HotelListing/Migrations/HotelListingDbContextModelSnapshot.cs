﻿// <auto-generated />
using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HotelListing.Migrations
{
    [DbContext(typeof(HotelListingDbContext))]
    partial class HotelListingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("HotelListing.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "England",
                            ShortName = "EN"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Scotland",
                            ShortName = "SC"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Wales",
                            ShortName = "WS"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ireland",
                            ShortName = "IE"
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Lorem Ipsum",
                            CountryId = 1,
                            Name = "Savoy",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Lorem Ipsum",
                            CountryId = 1,
                            Name = "Ritz",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 3,
                            Address = "Lorem Ipsum",
                            CountryId = 2,
                            Name = "St Andrews",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 4,
                            Address = "Lorem Ipsum",
                            CountryId = 2,
                            Name = "The Lodge",
                            Rating = 4.0
                        },
                        new
                        {
                            Id = 5,
                            Address = "Lorem Ipsum",
                            CountryId = 3,
                            Name = "St Davids",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 6,
                            Address = "Lorem Ipsum",
                            CountryId = 3,
                            Name = "Dragon Inn",
                            Rating = 3.5
                        },
                        new
                        {
                            Id = 7,
                            Address = "Lorem Ipsum",
                            CountryId = 4,
                            Name = "St Patricks",
                            Rating = 5.0
                        },
                        new
                        {
                            Id = 8,
                            Address = "Lorem Ipsum",
                            CountryId = 4,
                            Name = "Three Harps",
                            Rating = 3.5
                        });
                });

            modelBuilder.Entity("HotelListing.Data.Hotel", b =>
                {
                    b.HasOne("HotelListing.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("HotelListing.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}