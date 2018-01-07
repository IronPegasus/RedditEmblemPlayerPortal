using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditEmblemPlayerPortal.Data;
using RedditEmblemPlayerPortal.Models;
using RedditEmblemPlayerPortal.Models.Characters;

namespace RedditEmblemPlayerPortal.Services
{
  public class CharacterData : ICharacterData
  {
    private DatabaseContext _context;

    public CharacterData(DatabaseContext dbContext)
    {
      _context = dbContext;
    }

    public Unit Add(Unit character)
    {
      //_context.Characters.Add(character);
      //_context.SaveChanges();
      return character;
    }

    public Unit Get(int id)
    {
      return null; //return _context.Characters.FirstOrDefault(x => x.CharacterId == id);
    }
  }
}
