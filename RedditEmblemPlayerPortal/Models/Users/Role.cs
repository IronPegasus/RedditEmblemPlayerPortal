using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Users
{
  public class Role
  {
    public int RoleId { get; set; }

    [Required, MaxLength(32)]
    /// <summary>A unique string used to identify a role to a user.</summary>
    public string Name { get; set; }

    public virtual ICollection<xUserRole> xUserRoles { get; set; }

    [Required]
    [DefaultValue("true")]
    public bool Deletable { get; set; }

    [Required]
    [DefaultValue("false")]
    public bool SubmitTeamApplication { get; set; }
  }
}