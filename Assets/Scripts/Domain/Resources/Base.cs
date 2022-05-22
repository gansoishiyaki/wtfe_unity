using System.Collections.Generic;
using System;

namespace JSONSerializer
{
    /// <summary>
    /// ドメインの根幹
    /// </summary>
    public class Base
    {
        public string id;
    }

    /// <summary>
    /// Jsonシリアライズ用
    /// </summary>
    [Serializable]
    public class List<T> where T : Base
    {
        public System.Collections.Generic.List<T> list;
    }
}
