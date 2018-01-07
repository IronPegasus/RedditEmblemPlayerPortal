using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams.System.Skills
{
  public class MultiHitOffensiveSkill : OffensiveSkill
  {
    [Required]
    /// <summary>The number of attacks the user of the skill will attempt to perform</summary>
    public int NumberOfAttacks { get; set; }

    [Required]
    /// <summary>An enumeration indicating what type of damage the skill deals</summary>
    public ValueType DamageType { get; set; }

    [Required]
    /// <summary>The amount of damage the skill deals to the opponent. Can be a flat rate or damage percentage.</summary>
    public decimal DamageValue { get; set; }

    public void Activate()
    {

    }

    public override string ToString()
    {
      if ( DamageType == ValueType.Flat )
        return string.Format("Allows the user to make {0} consecutive attacks for {1} damage each.", NumberOfAttacks, DamageValue.ToString("0.##"));
      else
        return string.Format("Allows the user to make {0} consecutive attacks for {1}% damage each.", NumberOfAttacks, (DamageValue*100).ToString("0.##"));
    }
  }
}