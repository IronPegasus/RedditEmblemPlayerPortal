using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class WeaponClass
  {
    public int WeaponClassId { get; set; }

    [Required, MaxLength(16)]
    /// <summary>The name of the weapon class</summary>
    public string Name { get; set; }

    /// <summary>A list of the teams that the weapon class is available in</summary>
    public virtual ICollection<Team> Teams { get; set; }
  }
}