using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Aviate.Models
{

     [Table("Maintenance_Table")]
     public class Maintenance
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int MaintenanceID { get; set; }

          [Column("AIRCRAFTID")]
          [ForeignKey("Aircraft")]
          public int AircraftID { get; set; }

          [Column("TASK_DESCRIPTION")]
          public string? TaskDescription { get; set; }

          [Column("START_DATE")]
          public DateTime? StartDate { get; set; }

          [Column("END_DATE")]
          public DateTime? EndDate { get; set; }

          [Column("STATUS")]
          public string? Status { get; set; }

     }
}
