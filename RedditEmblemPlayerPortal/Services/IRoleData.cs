using RedditEmblemPlayerPortal.Models;
using RedditEmblemPlayerPortal.Models.Users;
using System.Collections.Generic;

namespace RedditEmblemPlayerPortal.Services
{
  public interface IRoleData
  {
    Role Add(Role role);
    Role Get(int id);
    Role Get(string roleName);
    IEnumerable<Role> GetAll();
  }
}