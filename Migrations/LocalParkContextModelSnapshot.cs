﻿// <auto-generated />
using LocalPark.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocalPark.Migrations
{
    [DbContext(typeof(LocalParkContext))]
    partial class LocalParkContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LocalPark.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Notes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Trails")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            City = "The Land of Test",
                            Name = "Test 1",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 2,
                            City = "The Land of Test",
                            Name = "Test 2",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 3,
                            City = "The Land of Test",
                            Name = "Test 3",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 4,
                            City = "The Land of Test",
                            Name = "Test 4",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 5,
                            City = "The Land of Test",
                            Name = "Test 5",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 6,
                            City = "The Land of Test",
                            Name = "Test 6",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 7,
                            City = "The Land of Test",
                            Name = "Test 7",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 8,
                            City = "The Land of Test",
                            Name = "Test 8",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 9,
                            City = "The Land of Test",
                            Name = "Test 9",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 10,
                            City = "The Land of Test",
                            Name = "Test 10",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        },
                        new
                        {
                            ParkId = 11,
                            City = "The Land of Test",
                            Name = "Test 11",
                            Notes = "Test this api is working",
                            Trails = "Test"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
