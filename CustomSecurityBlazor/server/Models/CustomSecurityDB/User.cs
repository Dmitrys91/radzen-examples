using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomSecurity.Models.CustomSecurityDb
{
  [Table("Users", Schema = "dbo")]
  public partial class User
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id
    {
      get;
      set;
    }

    public ICollection<UserRole> UserRoles { get; set; }
    public string Email
    {
      get;
      set;
    }
    public string PasswordHash
    {
      get;
      set;
    }
  }
}
