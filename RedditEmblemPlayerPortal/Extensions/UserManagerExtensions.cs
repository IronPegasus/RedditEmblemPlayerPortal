using Microsoft.AspNetCore.Identity;
using RedditEmblemPlayerPortal.Data;
using System.Security.Claims;

namespace RedditEmblemPlayerPortal.Extensions
{
  public static class UserManagerExtensions
  {
    public static string GetDiscordUsername(this UserManager<ApplicationUser> manager, ClaimsPrincipal user)
    {
      return "IronPegasus";  //user.DiscordUsername;
    }
  }
}