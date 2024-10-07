using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BooksHotelFullRestAPI.DTOs.Employee;
using BooksHotelFullRestAPI.Models;
using BooksHotelFullRestAPI.Data;
using BooksHotelFullRestAPI.Config;
using Swashbuckle.AspNetCore.Annotations;

namespace BooksHotelFullRestAPI.Controllers.Auth;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    protected readonly ApplicationDbContext Context;
    public readonly PasswordHasher<Employee> _passwordHasher;


    public AuthController(ApplicationDbContext context)
    {
        Context = context; // Injects the database context.
        _passwordHasher = new PasswordHasher<Employee>(); // Initialize the password hasher.
    }


    [HttpPost("register")]
    [SwaggerOperation(Summary = "Register a new user on the system.", Description = "This endpoint allows a new user to be registered in the system.")]
    [SwaggerResponse(200, "The new employee has successfully registered.")]
    [SwaggerResponse(400)]
    [SwaggerResponse(409)]
    public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
    {
        // Check if the model received in the request is valid.
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // If not valid, returns a 400 Bad Request error.
        }

        // Check if the email already exists in the database.
        var existingEmail = await Context.Employees.FirstOrDefaultAsync(employee => employee.Email == registerDTO.Email);

        if (existingEmail != null)
        {
            return Conflict("The email is already in use. Please choose another one."); // Returns 409 if the mail is duplicated.
        }

        // Creates a new Employee object with the data received in the DTO.
        var employee = new Employee
        {
            FirstName = registerDTO.FirstName,
            LastName = registerDTO.LastName,
            Email = registerDTO.Email,
            IdentificationNumber = registerDTO.IdentificationNumber,
            Password = registerDTO.Password
        };

        // Instance the password hasher to encrypt the password.
        var passwordHash = new PasswordHasher<Employee>();

        // Encrypts the user’s password before storing it in the database.
        employee.Password = passwordHash.HashPassword(employee, registerDTO.Password);

        // Adds the new user to the database.
        Context.Employees.Add(employee);

        // Saves changes to the database asynchronously.
        await Context.SaveChangesAsync();

        return Ok();
    }

    [HttpPost("login")]
    [SwaggerOperation(Summary = "Login a user on the system.", Description = "This endpoint allows a user to log in to the system using their email and password.")]
    [SwaggerResponse(200, "The user has successfully logged in and a JWT token has been generated.")]
    [SwaggerResponse(400)]
    [SwaggerResponse(401)]
    [SwaggerResponse(404)]
    public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
    {
        // Check if the model received in the request is valid.
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // If not valid, returns a 400 Bad Request error.
        }

        // Check if the email exists in the database.
        var employee = await Context.Employees.FirstOrDefaultAsync(employee => employee.Email == loginDTO.Email);
        if (employee == null)
        {
            return Unauthorized("Credentials not valid."); // Returns error 401 if the user is not found.
        }

        // Check if the password provided matches the stored one.
        var passwordResult = _passwordHasher.VerifyHashedPassword(employee, employee.Password, loginDTO.Password);
        if (passwordResult == PasswordVerificationResult.Failed)
        {
            return Unauthorized("Credentials not valid."); // Returns error 401 if the password is incorrect.
        }

        // If authentication is successful, it generates a JWT token for the user.
        var token = JWT.GenerateJwtToken(employee);

        // Returns an OK response with the user data and the JWT token.
        return Ok(new
        {
            id = employee.Id,
            firstName = employee.FirstName,
            lastName = employee.LastName,
            email = employee.Email,
            identificationNumber = employee.IdentificationNumber,
            token = token
        });
    }
}
