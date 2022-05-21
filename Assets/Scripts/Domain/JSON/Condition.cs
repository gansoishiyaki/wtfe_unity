using System.Collections.Generic;
using System;

namespace Resource
{
    /// <summary>
    /// 状態
    /// </summary>
    [Serializable]
    public class Condition : Base
    {
        public string name;
        public int priority;

        public List<Calcurate> effects;
    }
}