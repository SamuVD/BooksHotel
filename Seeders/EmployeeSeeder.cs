using Microsoft.EntityFrameworkCore;
using BooksHotelFullRestAPI.Models;

namespace BooksHotelFullRestAPI.Seeders;

public class EmployeeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                FirstName = "Carlos",
                LastName = "Sánchez",
                Email = "carlos.sanchez@example.com",
                IdentificationNumber = "1012345678",
                Password = "Hashedpassword1"  // Asegúrate de usar un hash
            },
            new Employee
            {
                Id = 2,
                FirstName = "Laura",
                LastName = "Martínez",
                Email = "laura.martinez@example.com",
                IdentificationNumber = "2012345678",
                Password = "Hashedpassword2"
            },
            new Employee
            {
                Id = 3,
                FirstName = "Andrés",
                LastName = "Hernández",
                Email = "andres.hernandez@example.com",
                IdentificationNumber = "3012345678",
                Password = "Hashedpassword_3"
            },
            new Employee
            {
                Id = 4,
                FirstName = "Marta",
                LastName = "Jiménez",
                Email = "marta.jimenez@example.com",
                IdentificationNumber = "4012345678",
                Password = "Hashedpassword4"
            },
            new Employee
            {
                Id = 5,
                FirstName = "Javier",
                LastName = "López",
                Email = "javier.lopez@example.com",
                IdentificationNumber = "5012345678",
                Password = "Hashedpassword5"
            },
            new Employee
            {
                Id = 6,
                FirstName = "Valentina",
                LastName = "Gutiérrez",
                Email = "valentina.gutierrez@example.com",
                IdentificationNumber = "6012345678",
                Password = "Hashedpassword6"
            },
            new Employee
            {
                Id = 7,
                FirstName = "Diego",
                LastName = "Torres",
                Email = "diego.torres@example.com",
                IdentificationNumber = "7012345678",
                Password = "Hashedpassword7"
            }
        );
    }
}
