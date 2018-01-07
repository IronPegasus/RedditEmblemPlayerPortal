using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Characters
{
  public class Character
  {
    public int CharacterId { get; set; }

    [Required, MaxLength(16)]
    /// <summary>The name of the character</summary>
    public string Name { get; set; }

    [Required]
    /// <summary>The gender of the character</summary>
    public Gender Gender { get; set; }

    [Required]
    /// <summary>The map sprite for the character</summary>
    public Image Sprite { get; set; }

    /// <summary>The portrait sprite for the character</summary>
    public Image Portrait { get; set; }

    /// <summary>The maximum HP the character can possess</summary>
    public int MaxHp { get; set; }

    /// <summary>The character's individual stat list</summary>
    public IEnumerable<CharacterStat> Stats { get; set; }
  }
}