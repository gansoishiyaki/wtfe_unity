﻿using System.Collections.Generic;
using System;

namespace Model.Trigger
{
    /// <summary>
    /// トリガーベース
    /// </summary>
    [Serializable]
    public class Base
    {
        public string id;
        public string name;
        public int range = 1;

        public int atk;
        public int hit;
        public int cri = 0;
        public bool is_black = false;
        public bool is_single = false;

        public List<string> attack_effects;
        public List<string> defence_effects;
    }

    /// <summary>
    /// Jsonシリアライズ用
    /// </summary>
    [Serializable]
    public class Serializer
    {
        public List<Base> triggers;
    }
}


