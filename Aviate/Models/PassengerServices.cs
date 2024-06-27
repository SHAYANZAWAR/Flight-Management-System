using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviate.Models
{
     [Table("PassengerServices_Table")]
     public class PassengerServices
     {

          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? ServiceID { get; set; }


          [Column("PASSENGERID")]
          [ForeignKey("User")]
          public int? PassengerID { get; set; }

          [Column("FLIGHTID")]
          [ForeignKey("Flight")]
          public int? FlightID { get; set; }


          [Column("SERVICE_TYPE")]
          public string? ServiceType { get; set; }

          [Column("SERVICE_DETAILS")]
          public string? ServiceDetails { get; set; }


          [Column("SERVICE_Time")]
          public DateOnly? ServiceTime { get; set; }


     }
}
