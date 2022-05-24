using System.Collections.Generic;
using System;

namespace Resource
{
    /// <summary>
    /// キャラクター
    /// </summary>
    [Serializable]
    public class Character : JSONSerializer.Base
    {
        // 表示名
        public string name;

        // 説明文
        public string description = "";

        // 初期ステータス
        public int level = 1;
        public int maxhp;
        public int atk;
        public int def;
        public int teh;
        public int spd;
        public int luk;
        public int move = 2;
        public int conducting = 0;
        public string move_type = "";

        // 成長率
        public CharacterRate rate;

        // 敵時のデフォルトステータス
        public StaticState enemy;

        // 属性
        public List<string> attributes = new List<string>();
        public List<string> triggers = new List<string>();
        public List<string> skills = new List<string>();
    }
}