using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksHotelFullRestAPI.Models;

[Table("bookings")]
public class Booking
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please, the room id is required.")]
    [Column("room_id")]
    public int RoomId { get; set; }

    [Required(ErrorMessage = "Please, the guest id is required.")]
    [Column("guest_id")]
    public int GuestId { get; set; }

    [Required(ErrorMessage = "Please, the employee id is required.")]
    [Column("employee_id")]
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Please, the start date is required.")]
    [Column("start_date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime StartDate { get; set; }

    [Column("end_date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime EndDate { get; set; }

    [Required(ErrorMessage = "Please, the total cost is required.")]
    [Column("total_cost")]
    [Range(0.1, 5000.0, ErrorMessage = "The price must be between {1} and {2}. And must be written in USD format.")]
    [DisplayFormat(DataFormatString = "{0:F2}")]
    public double TotalCost { get; set; }
}
