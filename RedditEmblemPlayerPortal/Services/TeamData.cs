using System.Linq;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models.Teams;

namespace RedditEmblemPlayerPortal.Services
{
  public class TeamData : ITeamData
  {
    private DatabaseContext _context;

    public TeamData(DatabaseContext dbContext)
    {
      _context = dbContext;
    }

    public Team Add(Team team)
    {
      _context.Teams.Add(team);
      _context.SaveChanges();
      return team;
    }

    public Team Get(int id)
    {
      return _context.Teams.FirstOrDefault(x => x.TeamId == id);
    }
  }
}
