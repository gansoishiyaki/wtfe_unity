using System;
using System.Collections.Generic;
using System.Linq;

namespace Feditor.Util
{
    [Serializable]
    public class JSONClass
    {
        public string key = "";
        public List<JSONTypeData> types = null;
        public List<JSONValueData> values = null;
    }
    [Serializable]
    public class JSONTypeData
    {
        public string name;
        public string type;
    }
    [Serializable]
    public class JSONValueData
    {
        public List<JSONElementData> elements;

        public Dictionary<string, string> toDictionary()
        {
            return elements.ToDictionary(e => e.key, e => e.value);
        }
    }
    [Serializable]
    public class JSONElementData
    {
        public string key;
        public string value;
    }
}