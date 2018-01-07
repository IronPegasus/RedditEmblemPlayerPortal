using RedditEmblemPlayerPortal.Models;
using RedditEmblemPlayerPortal.Models.Characters;
using System.Collections.Generic;

namespace RedditEmblemPlayerPortal.Services
{
  public interface ICharacterData
  {
    Unit Add(Unit character);
    Unit Get(int id);
  }
}