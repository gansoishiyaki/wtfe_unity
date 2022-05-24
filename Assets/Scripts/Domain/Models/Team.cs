using System.Collections.Generic;

namespace Domain
{
    /// <summary>
    /// チーム
    /// </summary>
    public class Team
    {
        public string id;
        public string name;
        public int priority = 1;

        public List<Character> characters;
    }
}