using RedditEmblemPlayerPortal.Models;
using RedditEmblemPlayerPortal.Models.Characters;
using System.Collections.Generic;

namespace RedditEmblemPlayerPortal.Services
{
  public interface ICharacterData
  {
    Character Add(Character character);
    Character Get(int id);
  }
}