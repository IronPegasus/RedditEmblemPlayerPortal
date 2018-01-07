using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams.System.Skills
{
  public class Skill
  {
    public int SkillId { get; set; }

    [Required, MaxLength(32)]
    /// <summary>The name of the skill</summary>
    public string Name { get; set; }

    [Required, MaxLength(256)]
    /// <summary>The description of the skill</summary>
    public string Description { get; set; }

    public void Activate(){ }
  }
}