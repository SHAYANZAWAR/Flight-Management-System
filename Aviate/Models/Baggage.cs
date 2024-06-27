using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Aviate.Models
{
     [Table("Baggage_Table")]
     public class Baggage
     {

          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

          public int? BaggageID { get; set; }


          [ForeignKey("User")]
          public string? PassengerID { get; set; }


          [ForeignKey("Flight")]
          public string? FlightID { get; set; }

          [Column("STATUS")]
          public string? Status { get; set; }

          [Column("LOCATION")]
          public string? Location { get; set; }

     }
}
