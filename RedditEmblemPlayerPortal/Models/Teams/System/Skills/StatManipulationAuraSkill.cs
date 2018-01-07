using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace RedditEmblemPlayerPortal.Models.Teams.System.Skills
{
  public class StatManipulationAuraSkill : AuraSkill
  {
    /// <summary>Indicates the units the skill will act upon</summary>
    [Required]
    public AuraTargetType Target { get; set; }

    [Required]
    /// <summary>The adjustments applied to the target's stats</summary>
    public List<TeamStatAdjustment> Adjustments { get; set; }

    public void Activate()
    {

    }

    public override string ToString()
    {
      string info = string.Format("apply {0} to {1}{2} within {3} tiles.",
        string.Join("/", (from a in Adjustments select a.ToString()).ToArray()),
        (Target == AuraTargetType.Self ? "this unit" : (Target == AuraTargetType.Allies ? "allies" : "enemies")),
        (Target == AuraTargetType.Self ? " when an ally is" : string.Empty),
        Radius
      );

      return base.ToString(info);
    }
  }
}