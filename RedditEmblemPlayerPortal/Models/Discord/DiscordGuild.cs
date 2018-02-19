using Newtonsoft.Json;
using RedditEmblemPlayerPortal.Models.Users;

namespace RedditEmblemPlayerPortal.Models.Discord
{
  public class DiscordGuildMember
  {
    [JsonProperty("user")]
    public DiscordUser User { get; set; }
  }
}