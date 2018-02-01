using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class TeamStatGrowth
  {
    public int TeamStatGrowthId { get; set; }

    [ForeignKey("TeamStat")]
    public int TeamStatId { get; set; }
    public TeamStat TeamStat { get; set; }

    [Required]
    public decimal Value { get; set; }
  }
}