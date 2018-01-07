using System;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams.System.Skills
{
  public class HPRestorationAuraSkill : AuraSkill
  {
    [Required]
    /// <summary>The target of this skill</summary>
    public AuraTargetType Target { get; set; }

    [Required]
    /// <summary>The type of healing the skill will do</summary>
    public ValueType HealType { get; set; }

    [Required]
    /// <summary>The amount the skill will heal. Can be a flat value or a percentage of max HP.</summary>
    public decimal HealAmount { get; set; }

    public void Activate()
    {
      
    }

    public override string ToString()
    {
      throw new NotImplementedException();
    }
  }
}