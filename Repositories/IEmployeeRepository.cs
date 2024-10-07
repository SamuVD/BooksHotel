using BooksHotelFullRestAPI.DTOs.Employee;
using BooksHotelFullRestAPI.Models;

namespace BooksHotelFullRestAPI.Repositories;

public interface IEmployeeRepository
{
    Task<Employee> Register(Employee employee);
    Task<Employee> Login(Employee employee);
    Task<IEnumerable<Employee>> GetAllEmployees();
    Task<bool> Delete(int id);
    Task<bool> CheckExistence(int id);
}
