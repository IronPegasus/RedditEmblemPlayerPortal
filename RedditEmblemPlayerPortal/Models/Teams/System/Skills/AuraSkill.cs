using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams.System.Skills
{
  public class AuraSkill : Skill
  {
    [Required]
    /// <summary>The number of tiles affected around the unit</summary>
    public int Radius { get; set; }

    [Required]
    /// <summary>An enum indicating when this skill is activated</summary>
    public AuraSkillActivation Activation { get; set; }

    public void Activate() { }

    public string ToString(string skillInfo)
    {
      if (Activation == AuraSkillActivation.Always)
        return string.Format("Always {0}", skillInfo);
      else if (Activation == AuraSkillActivation.PlayerPhaseStart)
        return string.Format("At the start of the player phase, {0}", skillInfo);
      else
        return string.Format("At the start of the enemy phase, {0}", skillInfo);
    }
  }
}