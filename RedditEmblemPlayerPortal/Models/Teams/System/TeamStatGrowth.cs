using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class TeamStatGrowth
  {
    [ForeignKey("TeamStat")]
    public int TeamStatId { get; set; }
    public TeamStat TeamStat { get; set; }

    [ForeignKey("UnitClass")]
    public int UnitClassId { get; set; }
    public UnitClass Class { get; set; }

    [Required]
    public decimal Value { get; set; }
  }
}