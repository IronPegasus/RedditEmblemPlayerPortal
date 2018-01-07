using RedditEmblemPlayerPortal.Models;
using RedditEmblemPlayerPortal.Models.Teams;
using System.Collections.Generic;

namespace RedditEmblemPlayerPortal.Services
{
  public interface ITeamData
  {
    Team Add(Team team);
    Team Get(int id);
  }
}