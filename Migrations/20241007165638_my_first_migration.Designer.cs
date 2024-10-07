﻿// <auto-generated />
using System;
using BooksHotelFullRestAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BooksHotelFullRestAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241007165638_my_first_migration")]
    partial class my_first_migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BooksHotelFullRestAPI.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("end_date");

                    b.Property<int>("GuestId")
                        .HasColumnType("int")
                        .HasColumnName("guest_id");

                    b.Property<int>("RoomId")
                        .HasColumnType("int")
                        .HasColumnName("room_id");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("start_date");

                    b.Property<double>("TotalCost")
                        .HasColumnType("double")
                        .HasColumnName("total_cost");

                    b.HasKey("Id");

                    b.ToTable("bookings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            EndDate = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 1,
                            RoomId = 1,
                            StartDate = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 275.0
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 1,
                            EndDate = new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 2,
                            RoomId = 3,
                            StartDate = new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 640.0
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 2,
                            EndDate = new DateTime(2024, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 3,
                            RoomId = 5,
                            StartDate = new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 480.0
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 2,
                            EndDate = new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 4,
                            RoomId = 7,
                            StartDate = new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 1000.0
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 3,
                            EndDate = new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            GuestId = 1,
                            RoomId = 2,
                            StartDate = new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalCost = 160.0
                        });
                });

            modelBuilder.Entity("BooksHotelFullRestAPI.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .HasColumnType("longtext")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext")
                        .HasColumnName("last_name");

                    b.Property<string>("Password")
                        .HasColumnType("longtext")
                        .HasColumnName("password");

                    b.HasKey("Id");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "carlos.sanchez@example.com",
                            FirstName = "Carlos",
                            IdentificationNumber = "1012345678",
                            LastName = "Sánchez",
                            Password = "Hashedpassword1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "laura.martinez@example.com",
                            FirstName = "Laura",
                            IdentificationNumber = "2012345678",
                            LastName = "Martínez",
                            Password = "Hashedpassword2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "andres.hernandez@example.com",
                            FirstName = "Andrés",
                            IdentificationNumber = "3012345678",
                            LastName = "Hernández",
                            Password = "Hashedpassword_3"
                        },
                        new
                        {
                            Id = 4,
                            Email = "marta.jimenez@example.com",
                            FirstName = "Marta",
                            IdentificationNumber = "4012345678",
                            LastName = "Jiménez",
                            Password = "Hashedpassword4"
                        },
                        new
                        {
                            Id = 5,
                            Email = "javier.lopez@example.com",
                            FirstName = "Javier",
                            IdentificationNumber = "5012345678",
                            LastName = "López",
                            Password = "Hashedpassword5"
                        },
                        new
                        {
                            Id = 6,
                            Email = "valentina.gutierrez@example.com",
                            FirstName = "Valentina",
                            IdentificationNumber = "6012345678",
                            LastName = "Gutiérrez",
                            Password = "Hashedpassword6"
                        },
                        new
                        {
                            Id = 7,
                            Email = "diego.torres@example.com",
                            FirstName = "Diego",
                            IdentificationNumber = "7012345678",
                            LastName = "Torres",
                            Password = "Hashedpassword7"
                        });
                });

            modelBuilder.Entity("BooksHotelFullRestAPI.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("first_name");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("identification_number");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("last_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("guests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Birthdate = new DateTime(1985, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "juan.perez@example.com",
                            FirstName = "Juan",
                            IdentificationNumber = "123456789",
                            LastName = "Pérez",
                            PhoneNumber = "3001234567"
                        },
                        new
                        {
                            Id = 2,
                            Birthdate = new DateTime(1990, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "ana.garcia@example.com",
                            FirstName = "Ana",
                            IdentificationNumber = "987654321",
                            LastName = "García",
                            PhoneNumber = "3109876543"
                        },
                        new
                        {
                            Id = 3,
                            Birthdate = new DateTime(1988, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luis.martinez@example.com",
                            FirstName = "Luis",
                            IdentificationNumber = "456789123",
                            LastName = "Martínez",
                            PhoneNumber = "3145678912"
                        },
                        new
                        {
                            Id = 4,
                            Birthdate = new DateTime(1995, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "maria.lopez@example.com",
                            FirstName = "María",
                            IdentificationNumber = "321654987",
                            LastName = "López",
                            PhoneNumber = "3159876543"
                        });
                });

            modelBuilder.Entity("BooksHotelFullRestAPI.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("availability");

                    b.Property<byte>("MaxOccupancyPerson")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("max_occupancy_person");

                    b.Property<double>("PricePerNight")
                        .HasColumnType("double")
                        .HasColumnName("price_per_night");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("room_number");

                    b.Property<int>("RoomTypeId")
                        .HasColumnType("int")
                        .HasColumnName("room_type_id");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("rooms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 55.0,
                            RoomNumber = "501",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Availability = false,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 60.0,
                            RoomNumber = "502",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 3,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 85.0,
                            RoomNumber = "503",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 4,
                            Availability = false,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 90.0,
                            RoomNumber = "504",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 5,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 160.0,
                            RoomNumber = "505",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 6,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 165.0,
                            RoomNumber = "506",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 7,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 220.0,
                            RoomNumber = "507",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 8,
                            Availability = false,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 225.0,
                            RoomNumber = "508",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 9,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 58.0,
                            RoomNumber = "509",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 62.0,
                            RoomNumber = "510",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 11,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 65.0,
                            RoomNumber = "601",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 12,
                            Availability = false,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 60.0,
                            RoomNumber = "602",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 75.0,
                            RoomNumber = "603",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 14,
                            Availability = false,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 70.0,
                            RoomNumber = "604",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 15,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 80.0,
                            RoomNumber = "605",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 16,
                            Availability = true,
                            MaxOccupancyPerson = (byte)1,
                            PricePerNight = 85.0,
                            RoomNumber = "606",
                            RoomTypeId = 1
                        },
                        new
                        {
                            Id = 17,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 95.0,
                            RoomNumber = "607",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 18,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 100.0,
                            RoomNumber = "608",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 19,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 105.0,
                            RoomNumber = "609",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 20,
                            Availability = false,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 92.0,
                            RoomNumber = "610",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 21,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 98.0,
                            RoomNumber = "701",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 22,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 110.0,
                            RoomNumber = "702",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 23,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 115.0,
                            RoomNumber = "703",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 24,
                            Availability = false,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 105.0,
                            RoomNumber = "704",
                            RoomTypeId = 2
                        },
                        new
                        {
                            Id = 25,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 170.0,
                            RoomNumber = "705",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 26,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 175.0,
                            RoomNumber = "706",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 27,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 160.0,
                            RoomNumber = "707",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 28,
                            Availability = false,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 180.0,
                            RoomNumber = "708",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 29,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 190.0,
                            RoomNumber = "709",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 30,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 195.0,
                            RoomNumber = "710",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 31,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 200.0,
                            RoomNumber = "801",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 32,
                            Availability = true,
                            MaxOccupancyPerson = (byte)2,
                            PricePerNight = 205.0,
                            RoomNumber = "802",
                            RoomTypeId = 3
                        },
                        new
                        {
                            Id = 33,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 240.0,
                            RoomNumber = "803",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 34,
                            Availability = false,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 250.0,
                            RoomNumber = "804",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 35,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 260.0,
                            RoomNumber = "805",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 36,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 255.0,
                            RoomNumber = "806",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 37,
                            Availability = false,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 265.0,
                            RoomNumber = "807",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 38,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 275.0,
                            RoomNumber = "808",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 39,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 280.0,
                            RoomNumber = "809",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 40,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 290.0,
                            RoomNumber = "810",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 41,
                            Availability = false,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 300.0,
                            RoomNumber = "811",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 42,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 310.0,
                            RoomNumber = "812",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 43,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 320.0,
                            RoomNumber = "813",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 44,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 330.0,
                            RoomNumber = "814",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 45,
                            Availability = true,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 340.0,
                            RoomNumber = "815",
                            RoomTypeId = 4
                        },
                        new
                        {
                            Id = 46,
                            Availability = false,
                            MaxOccupancyPerson = (byte)4,
                            PricePerNight = 350.0,
                            RoomNumber = "816",
                            RoomTypeId = 4
                        });
                });

            modelBuilder.Entity("BooksHotelFullRestAPI.Models.RoomType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("room_types");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Habitación básica con una cama individual",
                            Name = "Simple"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Habitación con dos camas individuales o una cama doble",
                            Name = "Doble"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Habitación lujosa con cama king size y sala de estar",
                            Name = "Suite"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Habitación espaciosa con varias camas para familias",
                            Name = "Familiar"
                        });
                });

            modelBuilder.Entity("BooksHotelFullRestAPI.Models.Room", b =>
                {
                    b.HasOne("BooksHotelFullRestAPI.Models.RoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomType");
                });
#pragma warning restore 612, 618
        }
    }
}
