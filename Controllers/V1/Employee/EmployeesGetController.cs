using BooksHotelFullRestAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BooksHotelFullRestAPI.Controllers.V1.Employee;

[Authorize]
[ApiController]
[Route("api/v1/employees")]
[Tags("employees")]
public class EmployeesGetController : EmployeesController
{
    public EmployeesGetController(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
    }

    [HttpGet]
    [SwaggerOperation(
        Summary = "Retrieve all employees.",
        Description = "This endpoint retrieves a list of all employees from the system."
    )]
    [SwaggerResponse(200, "A list of all employees has been successfully retrieved.")]
    public async Task<IActionResult> GetAllEmployees()
    {
        var employees = await servicios.GetAllEmployees();

        return Ok(employees);
    }
}
