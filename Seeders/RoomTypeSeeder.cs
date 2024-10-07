using Microsoft.EntityFrameworkCore;
using BooksHotelFullRestAPI.Models;

namespace BooksHotelFullRestAPI.Seeders;

public class RoomTypeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RoomType>().HasData(
            new RoomType { Id = 1, Name = "Simple", Description = "Habitación básica con una cama individual" },
            new RoomType { Id = 2, Name = "Doble", Description = "Habitación con dos camas individuales o una cama doble" },
            new RoomType { Id = 3, Name = "Suite", Description = "Habitación lujosa con cama king size y sala de estar" },
            new RoomType { Id = 4, Name = "Familiar", Description = "Habitación espaciosa con varias camas para familias" }
        );
    }
}
