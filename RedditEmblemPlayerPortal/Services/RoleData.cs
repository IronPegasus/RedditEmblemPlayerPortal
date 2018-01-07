using System.Collections.Generic;
using System.Linq;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models.Users;

namespace RedditEmblemPlayerPortal.Services
{
  public class RoleData : IRoleData
  {
    private DatabaseContext _context;

    public RoleData(DatabaseContext dbContext)
    {
      _context = dbContext;
    }

    public Role Add(Role role)
    {
      _context.Roles.Add(role);
      _context.SaveChanges();
      return role;
    }

    public Role Get(int id)
    {
      return _context.Roles.FirstOrDefault(x => x.RoleId == id);
    }

    public Role Get(string roleName)
    {
      return _context.Roles.FirstOrDefault(x => x.Name.Equals(roleName));
    }

    public IEnumerable<Role> GetAll()
    {
      return _context.Roles;
    }
  }
}
