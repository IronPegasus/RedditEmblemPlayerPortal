using System.ComponentModel.DataAnnotations.Schema;

namespace RedditEmblemPlayerPortal.Models.Teams
{
  public class xUnitClassPromotion
  {
    [ForeignKey("UnitClass")]
    public int PromotesFromId { get; set; }
    public UnitClass PromotesFrom { get; set; }

    [ForeignKey("UnitClass")]
    public int PromotesToId { get; set; }
    public UnitClass PromotesTo { get; set; }
  }
}