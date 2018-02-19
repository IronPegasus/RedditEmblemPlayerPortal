using Newtonsoft.Json;

namespace RedditEmblemPlayerPortal.Models.Users
{
  public class DiscordUser
  {
    private const string avatarURLBase = @"https://cdn.discordapp.com/avatars/{0}/{1}.png";

    [JsonProperty("id")]
    public string ID { get; set; }

    [JsonProperty("username")]
    public string Username { get; set; }

    [JsonProperty("discriminator")]
    public string Discriminator { get; set; }

    [JsonProperty("avatar")]
    public string Avatar { get; set; }

    /// <summary>
    /// Returns the URL string for the user's avatar image.
    /// </summary>
    /// <returns></returns>
    public string BuildDiscordAvatarURL()
    {
      return string.Format(avatarURLBase, ID, Avatar);
    }
  }
}