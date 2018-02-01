using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models.Characters;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class TeamPlayer
  {
    public int TeamPlayerId { get; set; }

    [ForeignKey("ApplicationUser")]
    public int UserId { get; set; }
    /// <summary>The user linked to the player instance</summary>
    public ApplicationUser User { get; set; }

    [ForeignKey("Character")]
    public int CharacterId { get; set; }
    /// <summary>The character owned by the player instance</summary>
    public Unit Character { get; set; }
  }
}