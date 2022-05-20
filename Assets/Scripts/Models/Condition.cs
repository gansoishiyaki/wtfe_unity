using System.Collections.Generic;
using System;

namespace Model.Condition
{
    /// <summary>
    /// 状態
    /// </summary>
    [Serializable]
    public class Base
    {
        public string id;
        public string name;
        public int priority;

        public List<Calcurate> effects;
    }
}