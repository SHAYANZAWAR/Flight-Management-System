using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Aviate.Models
{

     [Table("Crew_Table")]
     public class Crew
     {
          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int CrewID { get; set; }

          [Column("UserID")]
          [ForeignKey("User")]
          public int? UserID { get; set; }
          [Column("Name")]
          public string? Name { get; set; }

          [Column("Position")]
          public string? Position { get; set; }

          [Column("Qualifications")]
          public string? Qualifications { get; set; }

          [Column("Contact_Number")]
          public string? ContactNumber { get; set; }
     }
}
