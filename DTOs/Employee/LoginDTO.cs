using System.ComponentModel.DataAnnotations;

namespace BooksHotelFullRestAPI.DTOs.Employee;

public class LoginDTO
{
    [Required(ErrorMessage = "Please, the email is required.")]
    [MaxLength(255, ErrorMessage = "The email can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The email can't be shorter than {1} character.")]
    [EmailAddress(ErrorMessage = "You must write a correct email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please, the password is required.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.")]
    public string Password { get; set; }
}
