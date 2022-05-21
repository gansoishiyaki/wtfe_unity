using Resource;
using System.Collections.Generic;

namespace IRepository
{
    public interface IResourceRepository
    {
        public Dictionary<string, Character> Characters();
    }
}

