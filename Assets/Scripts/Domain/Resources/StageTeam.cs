using System.Collections.Generic;
using System;

namespace Resource
{
    [Serializable]
    public class StageTeam
    {
        public bool is_player = true;
        public List<StageCharacter> charas;
    }
}