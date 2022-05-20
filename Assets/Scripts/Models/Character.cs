using System.Collections.Generic;
using System;

namespace Model.Character
{
    /// <summary>
    /// キャラクターベース
    /// </summary>
    [Serializable]
    public class Base
    {
        // 識別子
        public string id;

        // 表示名
        public string name;

        // 初期ステータス
        public int atk;
        public int def;
        public int teh;
        public int spd;
        public int spe;
        public int luk;
        public int move;
        public int conducting;
        public string move_type;

        // 成長率
        public Rate rate;

        // 属性
        public List<Attribute> attributes;

        public MoveType moveType
        {
            get { return move_type.ToEnum(MoveType.walk); }
        }
    }


    /// <summary>
    /// Jsonシリアライズ用
    /// </summary>
    [Serializable]
    public class CharacterSerializer
    {
        public List<Base> characters;
    }
}
