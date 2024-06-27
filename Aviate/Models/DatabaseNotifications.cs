using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviate.Models
{

     [Table("Notifications")]
     public class DatabaseNotifications
     {
          [Key]
          public int Id { get; set; }
          [Column("TableName")]
          public string? TableName { get; set; }
          [Column("Action")]
          public string? Action { get; set; }
          [Column("Timestamp")]
          public DateTime Timestamp { get; set; }

          [Column("processed")]
          public bool Processed { get; set; }

          [Column("Row_Id")]
          public int? rowId { get; set; }

          [Column("AlteringRows")]
          public List<string>? alteringRows { get; set; }

     }
}
