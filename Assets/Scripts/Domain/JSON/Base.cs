using System.Collections.Generic;
using System;

namespace Resource
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
    public class Serializer<T> where T : Base
    {
        public List<T> list;
    }
}
