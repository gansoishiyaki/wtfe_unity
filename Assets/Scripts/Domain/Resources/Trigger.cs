using System;
using System.Collections.Generic;

namespace Resource
{
    /// <summary>
    /// トリガーベース
    /// </summary>
    [Serializable]
    public class Trigger : JSONSerializer.Base
    {
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
}
