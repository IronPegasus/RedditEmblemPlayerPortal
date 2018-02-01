using RedditEmblemPlayerPortal.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class xTeamGMA
  {
    [ForeignKey("Team")]
    public int TeamId { get; set; }
    public Team Team { get; set; }

    [ForeignKey("ApplicationUser")]
    public int UserId { get; set; }
    public ApplicationUser User { get; set; }
  }
}