namespace RedditEmblemPlayerPortal.Models
{
  /// <summary>An enumeration indicating the status of a Team. Defaults to "Workshop".</summary>
  public enum TeamStatus {
    Workshop = 0,
    Applied = 1,
    Official = 2
  };

  /// <summary>An enumeration indicating gender. Defaults to "Male".</summary>
  public enum Gender {
    Male = 0,
    Female = 1,
    Other
  };
}