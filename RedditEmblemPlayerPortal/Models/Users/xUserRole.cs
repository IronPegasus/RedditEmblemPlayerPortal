using RedditEmblemPlayerPortal.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Users
{
  public class xUserRole
  {
    [ForeignKey("ApplicationUser")]
    public string ID { get; set; }
    public ApplicationUser User { get; set; }

    [ForeignKey("Role")]
    public int RoleID { get; set; }
    public Role Role { get; set; }
  }
}
