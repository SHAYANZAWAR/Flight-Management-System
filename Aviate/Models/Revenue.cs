using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aviate.Models
{
     [Table("Revenue_Table")]
     public class Revenue
     {

          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? RevenueID { get; set; }

          [Column("TRANSACTION_DATE")]
          public DateOnly? TransactionDate { get; set; }

          [Column("AMOUNT")]
          public int? Amount { get; set; }

          [Column("SOURCE")]
          public string? Source { get; set;}

          [Column("DESTINATION")]
          public string? Description { get; set; }
     }
}
