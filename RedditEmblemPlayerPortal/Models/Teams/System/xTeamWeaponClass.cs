using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams.System
{
  public class xTeamWeaponClass
  {
    [ForeignKey("Team")]
    public int TeamId { get; set; }
    public Team Team { get; set; }

    [ForeignKey("WeaponClass")]
    public int WeaponClassId { get; set; }
    public WeaponClass WeaponClass { get; set; }
  }
}