using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Aviate.Models
{
     [Table("Flight_Table")]
     public class Flight
     {


          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? FlightID { get; set; }

          [Column("Departure_location")]
          public string? DepartureLocation { get; set; }

          [Column("DESTINATION")]
          public string? Destination { get; set; }

          [Column("DEPARTURE_TIME")]
          public DateTime? DepartureTime { get; set; }

          [Column("ARRIVAL_TIME")]
          public DateTime? ArrivalTime { get; set; }

          [Column("AIRCRAFTID")]
          public string? AircraftID { get; set; }

          [Column("STATUS")]
          public string? Status { get; set; }

          


     }
}
