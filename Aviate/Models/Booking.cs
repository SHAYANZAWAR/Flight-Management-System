using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aviate.Models;
namespace Aviate.Models
{
     [Table("Booking_Table")]
     public class Booking
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public string? BookingID { get; set; }

          [ForeignKey("Flight")]
          public int? FlightID { get; set; }

          [ForeignKey("User")]
          public string? UserID { get; set; }

          [Column("Seat_Type")]
          public string? SeatType { get; set; }

          [Column("Seat_Number")]
          public int? SeatNumber { get; set; }

          [Column("Price")]
          public int? Price { get; set; }

          [Column("Booking_Time")]
          public DateTime? BookingTime { get; set; }

          [Column("isPaid")]
          public bool? isPaid { get; set; }
          

     }
}
