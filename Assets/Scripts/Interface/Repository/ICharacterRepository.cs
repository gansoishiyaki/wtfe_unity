using System.Collections.Generic;
using DataStore;

namespace IRepository.DataStore
{
    public interface ICharacter
    {
        public Character Get(string id);
        public void Add(Character character);
    }
}
