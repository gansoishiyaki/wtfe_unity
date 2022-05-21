using System;
namespace Resource
{
    /// <summary>
    /// ステータス
    /// </summary>
    [Serializable]
    public class CharacterRate
    {
        public int hp;
        public int atk;
        public int def;
        public int teh;
        public int spd;
        public int luk;
        public int conducting = 0;
    }
}
