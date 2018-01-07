using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Characters
{
  public class Affinity
  {
    public int AffinityId { get; set; }

    [Required, MaxLength(16)]
    /// <summary>The name for the affinity</summary>
    public string Name { get; set; }

    public Image Sprite { get; set; }
  }
}