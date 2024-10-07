using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksHotelFullRestAPI.Models;

[Table("rooms")]
public class Room
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please, the room number is required.")]
    [Column("room_number")]
    [MaxLength(10, ErrorMessage = "The room number can't be longer than {1} characters.")]
    [MinLength(1, ErrorMessage = "The room number can't be shorter than {1} character.")]
    public string RoomNumber { get; set; }

    [Required(ErrorMessage = "Please, the room type id is required.")]
    [Column("room_type_id")]
    public int RoomTypeId { get; set; }

    [Required(ErrorMessage = "Please, the price per night is required.")]
    [Column("price_per_night")]
    [Range(0.1, 5000.0, ErrorMessage = "The price must be between {1} and {2}. And must be written in USD format.")]
    [DisplayFormat(DataFormatString = "{0:F2}")]
    public double PricePerNight { get; set; }

    [Required(ErrorMessage = "Please, the availability is required.")]
    [Column("availability")]
    public bool Availability { get; set; }

    [Required(ErrorMessage = "Please, the max occupancy person is required.")]
    [Column("max_occupancy_person")]
    [Range(1, 4, ErrorMessage = "The max occupancy person must be between {1} and {2}.")]
    public byte MaxOccupancyPerson { get; set; }

    [ForeignKey("RoomTypeId")]
    public RoomType RoomType { get; set; }
}
