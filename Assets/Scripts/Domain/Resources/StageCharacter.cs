using System;

namespace Resource
{
    /// <summary>
    /// ステータス
    /// </summary>
    [Serializable]
    public class StageCharacter
    {
        public string id = "";
        public Position pos;
        public bool has_staticstate = false;
        public StaticState state;
    }
}
