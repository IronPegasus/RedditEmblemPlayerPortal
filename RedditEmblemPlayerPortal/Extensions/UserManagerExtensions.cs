using Microsoft.AspNetCore.Identity;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models.Users;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RedditEmblemPlayerPortal.Extensions
{
  public static class UserManagerExtensions
  { 
    public static async Task<string> GetDiscordUsername(this UserManager<ApplicationUser> manager, ClaimsPrincipal user)
    {
      var currentUser = await manager.GetUserAsync(user);
      DiscordUser discordUser = await DiscordQuery.FetchCurrentUserInformation(manager, currentUser);
      return discordUser.Username;
    }

    public static async Task<string> GetDiscordAvatarURL(this UserManager<ApplicationUser> manager, ClaimsPrincipal user)
    {
      var currentUser = await manager.GetUserAsync(user);
      DiscordUser discordUser = await DiscordQuery.FetchCurrentUserInformation(manager, currentUser);
      return discordUser.BuildDiscordAvatarURL();
    }
  }
}