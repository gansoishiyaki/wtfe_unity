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

        // ステータスの上書きがあるか
        public bool has_state = false;
        public StaticState state;
    }
}
