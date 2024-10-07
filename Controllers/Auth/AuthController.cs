using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using BooksHotelFullRestAPI.DTOs.Employee;
using BooksHotelFullRestAPI.Config;
using Swashbuckle.AspNetCore.Annotations;
using BooksHotelFullRestAPI.Repositories;

namespace BooksHotelFullRestAPI.Controllers.Auth;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;


    public AuthController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }


    [HttpPost("register")]
    [SwaggerOperation(
        Summary = "Register a new user on the system.",
        Description = "This endpoint allows a new user to be registered in the system."
    )]
    [SwaggerResponse(200, "The new employee has successfully registered.")]
    [SwaggerResponse(400, "Invalid input data or validation error. Check the provided information.")]
    [SwaggerResponse(409, "Conflict occurred. The email may already be in use.")]
    public async Task<IActionResult> Register([FromBody] RegisterDTO registerDTO)
    {
        // Check if the model received in the request is valid.
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // If not valid, returns a 400 Bad Request error.
        }

        try
        {
            var employee = await _employeeRepository.Register(registerDTO);
            return Ok();
        }
        catch (Exception ex)
        {
            return Conflict(ex.Message);
        }
    }

    [HttpPost("login")]
    [SwaggerOperation(
    Summary = "Login a user on the system.",
    Description = "This endpoint allows a user to log in to the system using their email and password."
    )]
    [SwaggerResponse(200, "The user has successfully logged in and a JWT token has been generated.")]
    [SwaggerResponse(400, "Invalid input data or validation error. Check the provided information.")]
    [SwaggerResponse(409, "Conflict occurred. Unable to process login.")]
    public async Task<IActionResult> Login([FromBody] LoginDTO loginDTO)
    {
        // Check if the model received in the request is valid.
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState); // If not valid, returns a 400 Bad Request error.
        }

        try
        {
            var employee = await _employeeRepository.Login(loginDTO);
            
            // If authentication is successful, it generates a JWT token for the user.
            var token = JWT.GenerateJwtToken(employee);

            // Returns an OK response with the user data and the JWT token.
            return (new Employee
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                IdentificationNumber = employee.IdentificationNumber,
                token = token
            });

            return Ok();
        }
        catch (Exception ex)
        {
            return Conflict(ex.Message);
        }
    }
}
