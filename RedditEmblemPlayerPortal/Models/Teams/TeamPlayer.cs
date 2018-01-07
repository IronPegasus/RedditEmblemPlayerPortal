using RedditEmblemPlayerPortal.Models.Characters;
using RedditEmblemPlayerPortal.Models.Users;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class TeamPlayer
  {
    public int TeamPlayerId { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }
    /// <summary>The user linked to the player instance</summary>
    public User User { get; set; }

    [ForeignKey("Character")]
    public int CharacterId { get; set; }
    /// <summary>The character owned by the player instance</summary>
    public Unit Character { get; set; }
  }
}