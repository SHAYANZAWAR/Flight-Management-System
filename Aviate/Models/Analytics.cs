using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aviate.Models
{
     [Table("Analytics_Table")]
     public class Analytics
     {

          [Key]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? ReportID { get; set; }

          [Column("REPORT_TYPE")]
          public string? ReportType { get; set; }

          [Column("GENERATED_DATE")]
          public DateOnly? GeneratedDate { get; set; }

          [Column("DETAILS")]
          public string? Details { get; set; }


          [Column("ANALYSIS")]
          public string? Analysis { get; set; }
     }
}
