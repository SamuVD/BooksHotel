using Microsoft.EntityFrameworkCore;
using BooksHotelFullRestAPI.Models;

namespace BooksHotelFullRestAPI.Seeders;

public class BookingSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>().HasData(
            new Booking
            {
                Id = 1,
                RoomId = 1,         // ID de la habitación
                GuestId = 1,        // ID del huésped
                EmployeeId = 1,     // ID del empleado que gestionó la reserva
                StartDate = new DateTime(2024, 10, 10),
                EndDate = new DateTime(2024, 10, 15),
                TotalCost = 275.00 // Total cost based on nights and room rate
            },
            new Booking
            {
                Id = 2,
                RoomId = 3,
                GuestId = 2,
                EmployeeId = 1,
                StartDate = new DateTime(2024, 10, 12),
                EndDate = new DateTime(2024, 10, 20),
                TotalCost = 640.00 // Total cost based on nights and room rate
            },
            new Booking
            {
                Id = 3,
                RoomId = 5,
                GuestId = 3,
                EmployeeId = 2,
                StartDate = new DateTime(2024, 10, 15),
                EndDate = new DateTime(2024, 10, 18),
                TotalCost = 480.00 // Total cost based on nights and room rate
            },
            new Booking
            {
                Id = 4,
                RoomId = 7,
                GuestId = 4,
                EmployeeId = 2,
                StartDate = new DateTime(2024, 10, 5),
                EndDate = new DateTime(2024, 10, 10),
                TotalCost = 1000.00 // Total cost based on nights and room rate
            },
            new Booking
            {
                Id = 5,
                RoomId = 2,
                GuestId = 1,
                EmployeeId = 3,
                StartDate = new DateTime(2024, 10, 8),
                EndDate = new DateTime(2024, 10, 12),
                TotalCost = 160.00 // Total cost based on nights and room rate
            }
        );
    }
}
