using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class xClassTag
  {
    [ForeignKey("UnitClass")]
    public int UnitClassId { get; set; }
    public UnitClass Class { get; set; }

    [ForeignKey("Tag")]
    public int TagId { get; set; }
    public ClassTag Tag{get;set;}
  }
}