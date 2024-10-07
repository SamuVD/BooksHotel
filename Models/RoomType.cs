using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksHotelFullRestAPI.Models;

[Table("room_types")]
public class RoomType
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please, the name is required.")]
    [Column("name")]
    [MaxLength(50, ErrorMessage = "The name can't be longer than {1} characters.")]
    [MinLength(5, ErrorMessage = "The name can't be shorter than {1} character.")]
    public string Name { get; set; }

    [Column("description")]
    [MaxLength(255, ErrorMessage = "The description can't be longer than {1} characters.")]
    [MinLength(60, ErrorMessage = "The description can't be shorter than {1} characters.")]
    public string Description { get; set; }
}
