using RedditEmblemPlayerPortal.Models.Teams;

namespace RedditEmblemPlayerPortal.Services
{
  public interface ITeamPlayerData
  {
    TeamPlayer Add(TeamPlayer player);
    //TeamPlayer Get(int id);
  }
}