using System.Collections.Generic;

namespace Domain
{
    public class Mission
    {
        public string id;
        public string name;

        public int maxWidth = 6;
        public int maxHeight = 8;

        public List<Stage> stages;
    }
}
