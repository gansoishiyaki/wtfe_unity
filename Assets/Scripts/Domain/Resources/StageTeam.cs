using System.Collections.Generic;
using System;

namespace Resource
{
    [Serializable]
    public class StageTeam
    {
        public bool is_player = true;
        public int group_id;
        public List<StageCharacter> charas;
    }
}