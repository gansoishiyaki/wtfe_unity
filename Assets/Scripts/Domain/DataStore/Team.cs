using System.Collections.Generic;
using System;

namespace DataStore
{
    [Serializable]
    public class Team
    {
        public string id;
        public string name;

        public List<string> characters;
    }
}
