using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class TeamStat
  {
    public int TeamStatId { get; set; }

    [Required, StringLength(3)]
    /// <summary>The abbreviated name for the stat (ex. Str)</summary>
    public string Abbreviation { get; set; }

    [Required, MinLength(3), MaxLength(16)]
    /// <summary>The full name for the stat (ex. Strength)</summary>
    public string Name { get; set; }

    [MaxLength(64)]
    /// <summary>A brief description for the stat</summary>
    public string Description { get; set; }
    
  }
}