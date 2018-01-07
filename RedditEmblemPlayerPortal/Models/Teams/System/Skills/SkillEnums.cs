using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditEmblemPlayerPortal.Models.Teams.System.Skills
{
  /// <summary>An enumeration indicating whether a value is a flat rate or percentage. Defaults to "Flat".</summary>
  public enum ValueType
  {
    Flat = 0,
    Percentage = 1
  };

  /// <summary>An enumeration indicating the target of an aura skill. Defaults to "Self".</summary>
  public enum AuraTargetType
  {
    Self = 0,
    Allies = 1,
    Enemies = 2
  };

  /// <summary>An enumeration indicating the time at which an aura skill is activated. Defaults to "Always".</summary>
  public enum AuraSkillActivation
  {
    Always = 0,
    PlayerPhaseStart = 1,
    EnemyPhaseStart = 2
  };
}
