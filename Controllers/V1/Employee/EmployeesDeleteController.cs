using BooksHotelFullRestAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace BooksHotelFullRestAPI.Controllers.V1.Employee;

[Authorize]
[ApiController]
[Route("api/v1/employees")]
[Tags("employees")]
public class EmployeesDeleteController : EmployeesController
{
    public EmployeesDeleteController(IEmployeeRepository employeeRepository) : base(employeeRepository)
    {
    }

    [HttpDelete("{id}")]
    [SwaggerOperation(
        Summary = "Delete a user by ID.",
        Description = "This endpoint deletes a user from the system by their unique ID."
    )]
    [SwaggerResponse(204, "The user was successfully deleted. No content returned.")]
    [SwaggerResponse(404, "The user with the provided ID was not found.")]
    public async Task<IActionResult> Delete([FromRoute] int id)
    {
        var result = await servicios.Delete(id);

        if (!result)
        {
            return NotFound();
        }

        return NoContent();
    }
}
