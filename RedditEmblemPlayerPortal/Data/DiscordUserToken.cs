using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace RedditEmblemPlayerPortal.Data
{
    public class DiscordUserToken : IdentityUser
    {
      public string AccessToken { get; set; }
      public string TokenType { get; set; }
      public int ExpiresIn { get; set; }
      public string RefreshToken { get; set; }
      public string Scope { get; set; }
    }
}
