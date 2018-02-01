using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class TeamStatValue
  {
    public int TeamStatValueId { get; set; }

    [ForeignKey("TeamStat")]
    public int TeamStatId { get; set; }
    public TeamStat TeamStat { get; set; }

    [Required]
    /// <summary>The value of the stat</summary>
    public int Value { get; set; }
  }
}