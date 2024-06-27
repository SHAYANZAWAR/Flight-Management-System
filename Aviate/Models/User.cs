using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Drawing;

namespace Aviate.Models
{

     [Table("User_Table")]
     public class User
     {

          [Key]
          [Column("ID")]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? Id { get; set; } = null!;

          [Column("NAME")]
          public string? Name { get; set; }

          [Column("USERTYPE")]
          public string? UserType { get; set; }

          [Column("PHONE_NUMBER")]
          public string? PhoneNumber { get; set; }

          [Column("CNIC")]
          public string? Cnic { get; set; }

          [Column("isActive")]
          public bool isActive { get; set; }



     }

     [Table("User_Auth_Credential")]
     public class UserAuthCredential
     {
          [Key]
          [ForeignKey("User")]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? UserId { get; set; } = null!;

          [Column("USERNAME")]
          public string? Username { get; set; }

          [Column("EMAIL")]
          public string? Email { get; set; }

          [Column("PASSWORD_HASH")]
          public string? PasswordHash { get; set; }
     }


     [Table("User_image")]
     public class UserImage
     {
          [Key]
          [ForeignKey("User")]
          [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int? UserId { get; set; } = null!;

          [Column("IMAGE")]
          [DataType("BLOB")]
          public byte[] Image { get; set; } = null!;
     }
}
