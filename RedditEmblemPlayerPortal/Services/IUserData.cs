using RedditEmblemPlayerPortal.Models.Users;
using System.Collections.Generic;

namespace RedditEmblemPlayerPortal.Services
{
  public interface IUserData
  {
    User Add(User user);
    User Get(string discordId);
    IEnumerable<User> GetAll();
  }
}