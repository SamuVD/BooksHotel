using BooksHotelFullRestAPI.Data;
using BooksHotelFullRestAPI.Models;
using BooksHotelFullRestAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace BooksHotelFullRestAPI.Services;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly ApplicationDbContext Context;
    private readonly IPasswordHasher<Employee> _passwordHasher;


    public EmployeeRepository(ApplicationDbContext context)
    {
        Context = context;
        _passwordHasher = new PasswordHasher<Employee>();
    }

    public async Task<bool> CheckExistence(int id)
    {
        // Validate that the ID is a positive number
        if (id <= 0)
            throw new ArgumentException("The ID must be a positive number.");

        // Find if there is a user with the provided ID in the database.
        var employee = await Context.Employees.FindAsync(id);

        // Retornar true and el usuario exist, false and no
        return employee != null;
    }

    public async Task<Employee> Register(Employee employee)
    {
        // Check if the email already exists in the database.
        var existingEmail = await Context.Employees.FirstOrDefaultAsync(employee => employee.Email == employee.Email);

        if (existingEmail != null)
        {
            throw new InvalidOperationException("The email already exists in the database");
        }

        // Creates a new Employee object.
        var newEmployee = new Employee
        {
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Email = employee.Email,
            IdentificationNumber = employee.IdentificationNumber,
            Password = employee.Password
        };

        // Instance the password hasher to encrypt the password.
        var passwordHash = new PasswordHasher<Employee>();

        // Encrypts the user’s password before storing it in the database.
        employee.Password = passwordHash.HashPassword(employee, employee.Password);

        // Adds the new user to the database.
        Context.Employees.Add(employee);

        // Saves changes to the database asynchronously.
        await Context.SaveChangesAsync();

        return newEmployee;
    }

    public async Task<Employee> Login(Employee employee)
    {
        // Check if the email exists in the database.
        var employeeFound = await Context.Employees.FirstOrDefaultAsync(employee => employee.Email == employee.Email);
        if (employee == null)
        {
            throw new InvalidOperationException("The email doesn't exist in the database.");
        }

        // Check if the password provided matches the stored one.
        var passwordResult = _passwordHasher.VerifyHashedPassword(employee, employee.Password, employee.Password);
        if (passwordResult == PasswordVerificationResult.Failed)
        {
            throw new InvalidOperationException("The password doesn't exist in the database.");
        }

        return employee;
    }

    public async Task<IEnumerable<Employee>> GetAllEmployees()
    {
        return await Context.Employees.ToListAsync();
    }

    public async Task<bool> Delete(int id)
    {
        // Search the Employee in the database by its ID.
        var employeeToRemove = await Context.Employees.FindAsync(id);

        // If the employee is not found, return a exception.
        if (employeeToRemove == null)
        {
            throw new InvalidOperationException("The employee with the provided ID doesn't exist.");
        }

        // If the employee is found, remove it from the database context.
        Context.Employees.Remove(employeeToRemove);

        // Save the changes to the database asynchronously.
        await Context.SaveChangesAsync();

        return true;
    }
}
