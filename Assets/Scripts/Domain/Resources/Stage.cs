using System.Collections.Generic;
using System;

namespace Resource
{
    /// <summary>
    /// ステータス
    /// </summary>
    [Serializable]
    public class Stage
    {
        public string map;

        public List<StageTeam> teams;
    }
}
