using System;
using System.Collections.Generic;
using System.Linq;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models.Users;

namespace RedditEmblemPlayerPortal.Services
{
  public class UserData : IUserData
  {
    private DatabaseContext _context;

    public UserData(DatabaseContext dbContext)
    {
      _context = dbContext;
    }

    public User Add(User user)
    {
      _context.Users.Add(user);
      _context.SaveChanges();
      return user;
    }

    public User Get(string discordId)
    {
      return _context.Users.FirstOrDefault(x => x.DiscordUserId.Equals(discordId));
    }

    public IEnumerable<User> GetAll()
    {
      return _context.Users;
    }
  }
}
