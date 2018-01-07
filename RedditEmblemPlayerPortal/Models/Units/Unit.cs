using RedditEmblemPlayerPortal.Models.Teams;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Characters
{
  public class Unit
  {
    public int UnitId { get; set; }

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

    [Required]
    [DefaultValue(1)]
    public int Level { get; set; }

    [Required]
    /// <summary>The class for the character</summary>
    public UnitClass Class { get; set; }

    /// <summary>The affinity type associated with the character</summary>
    public Affinity Affinity { get; set; }

    /// <summary>The maximum HP the character can possess</summary>
    public int MaxHp { get; set; }

    /// <summary>The character's individual stat list</summary>
    public IEnumerable<UnitStat> Stats { get; set; }
  }
}