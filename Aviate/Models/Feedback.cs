using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviate.Models
{
     [Table("Feedback")]
     public class Feedback
     {
          [Key]
          public int Id { get; set; }
          public string Name { get; set; }
          public string Email { get; set; }

          // experience enum of Bad, Average, Good, Excellent
          public string Experience { get; set; }
          public string Message { get; set; }
     }
}
