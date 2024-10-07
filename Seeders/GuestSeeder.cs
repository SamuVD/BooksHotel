using Microsoft.EntityFrameworkCore;
using BooksHotelFullRestAPI.Models;

namespace BooksHotelFullRestAPI.Seeders;

public class GuestSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Guest>().HasData(
            new Guest
            {
                Id = 1,
                FirstName = "Juan",
                LastName = "Pérez",
                Email = "juan.perez@example.com",
                IdentificationNumber = "123456789",
                PhoneNumber = "3001234567",
                Birthdate = new DateTime(1985, 5, 1)
            },
            new Guest
            {
                Id = 2,
                FirstName = "Ana",
                LastName = "García",
                Email = "ana.garcia@example.com",
                IdentificationNumber = "987654321",
                PhoneNumber = "3109876543",
                Birthdate = new DateTime(1990, 7, 15)
            },
            new Guest
            {
                Id = 3,
                FirstName = "Luis",
                LastName = "Martínez",
                Email = "luis.martinez@example.com",
                IdentificationNumber = "456789123",
                PhoneNumber = "3145678912",
                Birthdate = new DateTime(1988, 3, 20)
            },
            new Guest
            {
                Id = 4,
                FirstName = "María",
                LastName = "López",
                Email = "maria.lopez@example.com",
                IdentificationNumber = "321654987",
                PhoneNumber = "3159876543",
                Birthdate = new DateTime(1995, 11, 30)
            }
        );
    }
}
