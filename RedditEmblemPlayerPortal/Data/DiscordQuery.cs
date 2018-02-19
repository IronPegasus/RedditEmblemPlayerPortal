using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RedditEmblemPlayerPortal.Models.Discord;
using RedditEmblemPlayerPortal.Models.Users;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RedditEmblemPlayerPortal.Data
{
  public class DiscordQuery
  {
    private static string RE_GUILD_ID = "393848757592129546"; //"153767654270697473";

    private static IConfiguration _configuration;

    internal static void Configure(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    #region Query URIs

    private const string QUERY_USER_SELF     = "users/@me";
    private const string QUERY_GUILD_MEMBERS = "guilds/{0}/members?limit=1000";
    private const string QUERY_USER_BY_ID    = "users/{0}";

    #endregion

    #region Query Functions

    public static async Task<DiscordUser> FetchCurrentUserInformation(UserManager<ApplicationUser> manager, ApplicationUser user)
    {
      string json = await ExecuteHttpRequestUser(manager, user, "GET", QUERY_USER_SELF);
      return JsonConvert.DeserializeObject<DiscordUser>(json);
    }

    public static async Task<DiscordUser> FetchUserByID(UserManager<ApplicationUser> manager, ApplicationUser user, string userid)
    {
      string json = await ExecuteHttpRequestUser(manager, user, "GET", QUERY_USER_BY_ID, new string[] { userid });
      return JsonConvert.DeserializeObject<DiscordUser>(json);
    }

    public static bool IsUserREMember(string userId)
    {
      string json = ExecuteHttpRequestBot("GET", QUERY_GUILD_MEMBERS, new string[] { RE_GUILD_ID });
      List<DiscordGuildMember> guilds = JsonConvert.DeserializeObject<List<DiscordGuildMember>>(json);
      return guilds.Any(x => x.User.ID.Equals(userId));
    }

    #endregion

    #region Helper Functions

    private static async Task<string> GetUserAccessToken(UserManager<ApplicationUser> manager, ApplicationUser user)
    {
      return await manager.GetAuthenticationTokenAsync(user, "Discord", "access_token");
    }

    private static string ExecuteHttpRequestBot(string requestType, string query, string[] queryParms = null)
    {
      queryParms = queryParms ?? new string[0];
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("https://discordapp.com/api/" + query, queryParms));
      request.Method = requestType;
      request.Headers.Add("Authorization", "Bot " + _configuration["Discord:BotToken"]);

      string returnVal = string.Empty;
      using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
      using (Stream stream = response.GetResponseStream())
      using (StreamReader reader = new StreamReader(stream))
      {
        returnVal = reader.ReadToEnd();
      }

      return returnVal;
    }

    private static async Task<string> ExecuteHttpRequestUser(UserManager<ApplicationUser> manager, ApplicationUser user, string requestType, string query, string[] queryParms = null)
    {
      queryParms = queryParms ?? new string[0];
      HttpWebRequest request = (HttpWebRequest)WebRequest.Create(string.Format("https://discordapp.com/api/" + query, queryParms));
      request.Method = requestType;
      request.Headers.Add("Authorization", "Bearer " + await GetUserAccessToken(manager, user));

      string returnVal = string.Empty;
      using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
      using (Stream stream = response.GetResponseStream())
      using (StreamReader reader = new StreamReader(stream))
      {
        returnVal = reader.ReadToEnd();
      }

      return returnVal;
    }

    #endregion
  }
}
