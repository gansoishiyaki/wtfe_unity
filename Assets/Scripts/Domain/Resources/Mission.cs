using System.Collections.Generic;
using System;

namespace Resource
{
    /// <summary>
    /// ステータス
    /// </summary>
    [Serializable]
    public class Mission : JSONSerializer.Base
    {
        public string name;

        public List<Stage> stages;
    }
}
