using System.Collections.Generic;
using System.Linq;
using IRepository;

namespace DataStore.JSON
{
    public class Handler : IStore
    {
        private Main data;

        // Repositoryから直接アクセスさせる
        public Dictionary<string, Character> characters;
        public Dictionary<string, Team> teams;

        public Handler()
        {
            // TODO: 読み込み処理
            data = new Main();
            data.characters = new List<Character>();
            data.teams = new List<Team>();

            characters = data.characters.ToDictionary(c => c.id);
            teams = data.teams.ToDictionary(c => c.id);
        }

        void IStore.Save()
        {
            data.characters = characters.Values.ToList();
            data.teams = teams.Values.ToList();

            // TODO: 保存処理
        }
    }
}