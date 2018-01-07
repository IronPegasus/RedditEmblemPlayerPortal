using System;
using System.Collections.Generic;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models.Teams;

namespace RedditEmblemPlayerPortal.Services
{
  public class TeamPlayerData : ITeamPlayerData
  {
    private DatabaseContext _context;

    public TeamPlayerData(DatabaseContext dbContext)
    {
      _context = dbContext;
    }

    public TeamPlayer Add(TeamPlayer player)
    {
      //_context.TeamPlayers.Add(player);
      //_context.SaveChanges();
      return player;
    }
  }
}
