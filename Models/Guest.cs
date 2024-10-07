using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksHotelFullRestAPI.Models;

[Table("guests")]
public class Guest
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please, the first name is required.")]
    [Column("first_name")]
    [MaxLength(50, ErrorMessage = "The first name can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The first name can't be shorter than {1} character.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Please, the last name is required.")]
    [Column("last_name")]
    [MaxLength(50, ErrorMessage = "The last name can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The last name can't be shorter than {1} character.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Please, the email is required.")]
    [Column("email")]
    [MaxLength(255, ErrorMessage = "The email can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The email can't be shorter than {1} character.")]
    [EmailAddress(ErrorMessage = "You must write a correct email format.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please, the identification number is required.")]
    [Column("identification_number")]
    [MaxLength(20, ErrorMessage = "The identification number can't be longer than {1} characters.")]
    [MinLength(7, ErrorMessage = "The identification number can't be shorter than {1} character.")]
    public string IdentificationNumber { get; set; }    

    [Required(ErrorMessage = "Please, the phone number is required.")]
    [Column("phone_number")]
    [MaxLength(20, ErrorMessage = "The phone number can't be longer than {1} characters.")]
    [MinLength(7, ErrorMessage = "The phone number can't be shorter than {1} character.")]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }

    [Column("birthdate")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Birthdate { get; set; }
}
