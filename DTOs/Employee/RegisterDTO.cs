using System.ComponentModel.DataAnnotations;

namespace BooksHotelFullRestAPI.DTOs.Employee;

public class RegisterDTO
{
    [Required(ErrorMessage ="Please, the first name is required.")]
    [MaxLength(50, ErrorMessage = "The first name can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The first name can't be shorter than {1} character.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please, the last name is required.")]
    [MaxLength(50, ErrorMessage = "The last name can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The last name can't be shorter than {1} character.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Please, the email is required.")]
    [MaxLength(255, ErrorMessage = "The email can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The email can't be shorter than {1} character.")]
    [EmailAddress(ErrorMessage = "You must write a correct email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please, the identification number is required.")]
    [MaxLength(20, ErrorMessage = "The identification number can't be longer than {1} characters.")]
    [MinLength(7, ErrorMessage = "The identification number can't be shorter than {1} character.")]
    public string IdentificationNumber { get; set; }

    [Required(ErrorMessage = "Please, the password is required.")]
    [MaxLength(255, ErrorMessage = "The password can't be longer than {1} characters.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$", ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, and one number.")]
    public string Password { get; set; }
}
