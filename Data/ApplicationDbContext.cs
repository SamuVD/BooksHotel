using Microsoft.EntityFrameworkCore;
using BooksHotelFullRestAPI.Models;
using BooksHotelFullRestAPI.Seeders;

namespace BooksHotelFullRestAPI.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Guest> Guests { get; set; }
    public DbSet<Booking> Bookings { get; set; }


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        EmployeeSeeder.Seed(modelBuilder);
        GuestSeeder.Seed(modelBuilder);
        RoomSeeder.Seed(modelBuilder);
        RoomTypeSeeder.Seed(modelBuilder);
        BookingSeeder.Seed(modelBuilder);
    }
}
