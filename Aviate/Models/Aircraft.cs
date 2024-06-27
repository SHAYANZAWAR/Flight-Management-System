using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aviate.Models
{
     [Table("Aircraft_Table")]
     public class Aircraft
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? AircraftID { get; set; }

          [Column("AIRCRAFT_NAME")]
          public string? AircraftName { get; set; }

          [Column("AIRCRAFT_TYPE")]
          public string? AircraftType { get; set; }

          [Column("TOTAL_SEATS")]
          public string? TotalSeats { get; set; }

          [Column("BUSINESS_SEATS")]
          public string? BusinessSeats { get; set; }

          [Column("ECONOMY_SEATS")]
          public string? EconomySeats { get; set; }

          [Column("BUSINESS_PRICE")]
          public string? BusinessPrice { get; set; }

          [Column("ECONOMY_PRICE")]
          public string? EconomyPrice { get; set; }

          [Column("Usable")]
          public bool? Usable { get; set; }
     }
}
