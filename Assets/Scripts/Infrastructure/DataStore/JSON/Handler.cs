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

        public Handler()
        {
            // TODO: 読み込み処理
            data = new Main();
            data.characters = new List<Character>();

            characters = data.characters.ToDictionary(c => c.id);
        }

        void IStore.Save()
        {
            data.characters = characters.Values.ToList();

            // TODO: 保存処理
        }
    }
}