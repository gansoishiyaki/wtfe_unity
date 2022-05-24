using System.Collections.Generic;

namespace Domain
{
    public class StageTeam
    {
        // 操作可能か
        public bool isPlayer = true;
        // 協力している場合は同じIDが振られる
        public int group_id;
        public List<StageCharacter> characters;
    }
}
