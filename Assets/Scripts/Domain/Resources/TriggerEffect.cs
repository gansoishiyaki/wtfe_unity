using System.Collections.Generic;
using System;

namespace Resource
{
    /// <summary>
    /// トリガー効果
    /// </summary>
    [Serializable]
    public class TriggerEffect : JSONSerializer.Base
    {
        public string exec_type;
        public string target_type;
        public string rate_type;
    }
}