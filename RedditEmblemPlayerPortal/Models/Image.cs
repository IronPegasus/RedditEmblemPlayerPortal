using System.ComponentModel.DataAnnotations;

namespace RedditEmblemPlayerPortal.Models
{
    public class Image
    {
      public int ImageId { get; set; }
      
      [Required]
      /// <summary>The byte stream associated with the sprite</summary>
      public byte[] Data { get; set; }
    }
}
