using RedditEmblemPlayerPortal.Models.Characters;
using RedditEmblemPlayerPortal.Models.Teams;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models
{
  public class CharacterStat
  {
    [ForeignKey("Character")]
    public int CharacterId { get; set; }
    /// <summary>The character that owns the stat</summary>
    public Character Character { get; set; }

    [ForeignKey("TeamStat")]
    public int TeamStatId { get; set; }
    /// <summary>The team stat represented by the stat</summary>
    public TeamStat TeamStat { get; set; }

    [Required]
    /// <summary>The integer value of the stat</summary>
    public int Value { get; set; }
  }
}