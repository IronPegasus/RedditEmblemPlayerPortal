using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class ClassTag
  {
    public int ClassTagId { get; set; }

    [Required, MaxLength(16)]
    /// <summary>The name of the tag</summary>
    public string Name { get; set; }

    /// <summary>A list of classes that this tag is associated with</summary>
    public virtual List<xClassTag> Classes { get; set; }
  }
}