using Resource;
using System.Collections.Generic;

namespace IRepository
{
    public interface IResource
    {
        public Dictionary<string, Character> Characters();
        public Dictionary<string, Mission> Missions();
    }
}

