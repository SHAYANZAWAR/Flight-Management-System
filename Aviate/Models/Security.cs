using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aviate.Models
{
     [Table("Security_Table")]
     public class Security
     {

          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? SafetyID { get; set; }

          [Column("EVENT_DATE")]
          public DateOnly? EventDate { get; set; }

          [Column("Description")]
          public string? Description { get; set; }

          [Column("SEVERITY")]
          public string? Severity { get; set; }

          [Column("RESOLUTION")]
          public string? Resolution { get; set; }
     }
}
