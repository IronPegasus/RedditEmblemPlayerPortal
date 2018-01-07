using RedditEmblemPlayerPortal.Models.Users;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class xTeamGMA
  {
    [ForeignKey("Team")]
    public int TeamId { get; set; }
    public Team Team { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }
  }
}