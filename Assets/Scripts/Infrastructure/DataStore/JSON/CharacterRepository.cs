using IRepository.DataStore;

namespace DataStore.JSON
{
    /// <summary>
    /// キャラクターデータを扱うクラス
    /// </summary>
    public class CharacterRepository : ICharacter
    {
        private Handler handler;

        public CharacterRepository(Handler handler)
        {
            this.handler = handler;
        }

        Character ICharacter.Get(string id)
        {
            return handler.characters[id];
        }

        void ICharacter.Add(Character character)
        {
            handler.characters.Add(character.id, character);
        }
    }
}