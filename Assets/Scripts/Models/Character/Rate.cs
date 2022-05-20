using System;
namespace Model.Character
{
    /// <summary>
    /// ステータス
    /// </summary>
    [Serializable]
    public class Rate
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
