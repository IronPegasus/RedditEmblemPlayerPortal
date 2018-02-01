using RedditEmblemPlayerPortal.Models.Teams.System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class UnitClass
  {
    public int UnitClassId { get; set; }

    /// <summary>The name for the class</summary>
    [Required, MaxLength(32)]
    public string Name { get; set; }

    /// <summary>A list of all the stat bases for this class</summary>
    public List<TeamStatValue> StatBases { get; set; }

    /// <summary>A list of all the stat caps for this class</summary>
    public List<TeamStatValue> StatCaps { get; set; }

    /// <summary>A list of all the stat growths for this class</summary>
    public List<TeamStatGrowth> StatGrowths { get; set; }

    /// <summary>A list of the weapon classes usable by this class</summary>
    public List<WeaponClass> WeaponClasses { get; set; }

    /// <summary>A list of the classes that this class is available as a promotion for</summary>
    public List<UnitClass> PromotesFrom { get; set; }

    /// <summary>A list of the classes that this class is available to promote to</summary>
    public List<UnitClass> PromotesTo { get; set; }

    /// <summary>A list of tags associated with this class</summary>
    public virtual ICollection<xClassTag> Tags { get; set; }
  }
}