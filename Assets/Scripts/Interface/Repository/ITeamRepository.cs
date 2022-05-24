using DataStore;
using System.Collections.Generic;

namespace IRepository.DataStore
{
    public interface ITeam
    {
        public Team Get(string id);
        public void Set(Team team);
        public bool Exist(string id);
    }
}
