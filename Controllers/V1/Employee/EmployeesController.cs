using BooksHotelFullRestAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BooksHotelFullRestAPI.Controllers.V1.Employee;

[ApiController]
[Route("api/v1/employees")]
public class EmployeesController : ControllerBase
{
    protected readonly IEmployeeRepository servicios;

    public EmployeesController(IEmployeeRepository employeeRepository)
    {
        servicios = employeeRepository;
    }
}
