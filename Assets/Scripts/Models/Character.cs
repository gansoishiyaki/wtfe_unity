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
        public int level;
        public int maxhp;
        public int atk;
        public int def;
        public int teh;
        public int spd;
        public int spe;
        public int luk;
        public int move = 2;
        public int conducting = 0;
        public string move_type = "";

        // 成長率
        public Rate rate;

        // 属性
        public List<string> attributes = new List<string>();
        public List<string> triggers = new List<string>();
        public List<string> skills = new List<string>();

        /// <summary>
        /// 移動タイプ
        /// </summary>
        public MoveType MoveType
        {
            get { return move_type.ToEnum(MoveType.walk); }
        }

        /// <summary>
        /// 属性を持っているか
        /// </summary>
        /// <param name="attribute"></param>
        /// <returns></returns>
        public bool HasAttributes(Attribute attribute)
        {
            return attributes.Contains(attribute.ToString());
        }

        /// <summary>
        /// トリガーオブジェクト
        /// </summary>
        public List<Trigger.Base> Triggers
        {
            get
            {
                var tc = GameController.getInstance.systemData.triggerController;
                return triggers.ConvertAll(t => tc.models[t]);
            }
        }
    }

    /// <summary>
    /// Jsonシリアライズ用
    /// </summary>
    [Serializable]
    public class Serializer
    {
        public List<Base> characters;
    }
}