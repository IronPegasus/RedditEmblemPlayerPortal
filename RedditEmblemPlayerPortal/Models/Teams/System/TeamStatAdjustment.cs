using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams.System
{
  public class TeamStatAdjustment
  {
    [Required]
    /// <summary>The stat affected by this adjustment</summary>
    public TeamStat Stat { get; set; }

    [Required]
    /// <summary>The amount the stat is adjusted by</summary>
    public int Value { get; set; }

    /// <summary>Returns a string representing the adjustment (ex. +3 Str / -2 Mag)</summary>
    public override string ToString()
    {
      return string.Format("{0} {1}", Value.ToString("+#;-#;+0"), Stat.Abbreviation);
    }
  }
}