using Microsoft.EntityFrameworkCore;
using BooksHotelFullRestAPI.Models;

namespace BooksHotelFullRestAPI.Seeders;

public class RoomSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Room>().HasData(
new Room
{
    Id = 1,
    RoomNumber = "501",
    RoomTypeId = 1, // Habitación Simple
    PricePerNight = 55.00,
    Availability = true,
    MaxOccupancyPerson = 1
},
new Room
{
    Id = 2,
    RoomNumber = "502",
    RoomTypeId = 1, // Habitación Simple
    PricePerNight = 60.00,
    Availability = false,
    MaxOccupancyPerson = 1
},
new Room
{
    Id = 3,
    RoomNumber = "503",
    RoomTypeId = 2, // Habitación Doble
    PricePerNight = 85.00,
    Availability = true,
    MaxOccupancyPerson = 2
},
new Room
{
    Id = 4,
    RoomNumber = "504",
    RoomTypeId = 2, // Habitación Doble
    PricePerNight = 90.00,
    Availability = false,
    MaxOccupancyPerson = 2
},
new Room
{
    Id = 5,
    RoomNumber = "505",
    RoomTypeId = 3, // Suite
    PricePerNight = 160.00,
    Availability = true,
    MaxOccupancyPerson = 2
},
new Room
{
    Id = 6,
    RoomNumber = "506",
    RoomTypeId = 3, // Suite
    PricePerNight = 165.00,
    Availability = true,
    MaxOccupancyPerson = 2
},
new Room
{
    Id = 7,
    RoomNumber = "507",
    RoomTypeId = 4, // Habitación Familiar
    PricePerNight = 220.00,
    Availability = true,
    MaxOccupancyPerson = 4
},
new Room
{
    Id = 8,
    RoomNumber = "508",
    RoomTypeId = 4, // Habitación Familiar
    PricePerNight = 225.00,
    Availability = false,
    MaxOccupancyPerson = 4
},
new Room { Id = 9, RoomNumber = "509", RoomTypeId = 1, PricePerNight = 58.00, Availability = true, MaxOccupancyPerson = 1 },
new Room { Id = 10, RoomNumber = "510", RoomTypeId = 1, PricePerNight = 62.00, Availability = true, MaxOccupancyPerson = 1 },
new Room { Id = 11, RoomNumber = "601", RoomTypeId = 1, PricePerNight = 65.00, Availability = true, MaxOccupancyPerson = 1 },
new Room { Id = 12, RoomNumber = "602", RoomTypeId = 1, PricePerNight = 60.00, Availability = false, MaxOccupancyPerson = 1 },
new Room { Id = 13, RoomNumber = "603", RoomTypeId = 1, PricePerNight = 75.00, Availability = true, MaxOccupancyPerson = 1 },
new Room { Id = 14, RoomNumber = "604", RoomTypeId = 1, PricePerNight = 70.00, Availability = false, MaxOccupancyPerson = 1 },
new Room { Id = 15, RoomNumber = "605", RoomTypeId = 1, PricePerNight = 80.00, Availability = true, MaxOccupancyPerson = 1 },
new Room { Id = 16, RoomNumber = "606", RoomTypeId = 1, PricePerNight = 85.00, Availability = true, MaxOccupancyPerson = 1 },
new Room { Id = 17, RoomNumber = "607", RoomTypeId = 2, PricePerNight = 95.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 18, RoomNumber = "608", RoomTypeId = 2, PricePerNight = 100.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 19, RoomNumber = "609", RoomTypeId = 2, PricePerNight = 105.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 20, RoomNumber = "610", RoomTypeId = 2, PricePerNight = 92.00, Availability = false, MaxOccupancyPerson = 2 },
new Room { Id = 21, RoomNumber = "701", RoomTypeId = 2, PricePerNight = 98.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 22, RoomNumber = "702", RoomTypeId = 2, PricePerNight = 110.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 23, RoomNumber = "703", RoomTypeId = 2, PricePerNight = 115.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 24, RoomNumber = "704", RoomTypeId = 2, PricePerNight = 105.00, Availability = false, MaxOccupancyPerson = 2 },
new Room { Id = 25, RoomNumber = "705", RoomTypeId = 3, PricePerNight = 170.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 26, RoomNumber = "706", RoomTypeId = 3, PricePerNight = 175.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 27, RoomNumber = "707", RoomTypeId = 3, PricePerNight = 160.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 28, RoomNumber = "708", RoomTypeId = 3, PricePerNight = 180.00, Availability = false, MaxOccupancyPerson = 2 },
new Room { Id = 29, RoomNumber = "709", RoomTypeId = 3, PricePerNight = 190.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 30, RoomNumber = "710", RoomTypeId = 3, PricePerNight = 195.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 31, RoomNumber = "801", RoomTypeId = 3, PricePerNight = 200.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 32, RoomNumber = "802", RoomTypeId = 3, PricePerNight = 205.00, Availability = true, MaxOccupancyPerson = 2 },
new Room { Id = 33, RoomNumber = "803", RoomTypeId = 4, PricePerNight = 240.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 34, RoomNumber = "804", RoomTypeId = 4, PricePerNight = 250.00, Availability = false, MaxOccupancyPerson = 4 },
new Room { Id = 35, RoomNumber = "805", RoomTypeId = 4, PricePerNight = 260.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 36, RoomNumber = "806", RoomTypeId = 4, PricePerNight = 255.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 37, RoomNumber = "807", RoomTypeId = 4, PricePerNight = 265.00, Availability = false, MaxOccupancyPerson = 4 },
new Room { Id = 38, RoomNumber = "808", RoomTypeId = 4, PricePerNight = 275.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 39, RoomNumber = "809", RoomTypeId = 4, PricePerNight = 280.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 40, RoomNumber = "810", RoomTypeId = 4, PricePerNight = 290.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 41, RoomNumber = "811", RoomTypeId = 4, PricePerNight = 300.00, Availability = false, MaxOccupancyPerson = 4 },
new Room { Id = 42, RoomNumber = "812", RoomTypeId = 4, PricePerNight = 310.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 43, RoomNumber = "813", RoomTypeId = 4, PricePerNight = 320.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 44, RoomNumber = "814", RoomTypeId = 4, PricePerNight = 330.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 45, RoomNumber = "815", RoomTypeId = 4, PricePerNight = 340.00, Availability = true, MaxOccupancyPerson = 4 },
new Room { Id = 46, RoomNumber = "816", RoomTypeId = 4, PricePerNight = 350.00, Availability = false, MaxOccupancyPerson = 4 }
        );
    }
}
