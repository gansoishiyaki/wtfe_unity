using System.Collections.Generic;
using System;

namespace DataStore
{
    /// <summary>
    /// キャラクター
    /// </summary>
    [Serializable]
    public class Character : JSONSerializer.Base
    {
        public string name;

        // 初期ステータス
        public int level;
        public int maxhp;
        public int hp;
        public int atk;
        public int def;
        public int teh;
        public int spd;
        public int luk;
        public int move;
        public int conducting;
    }
}