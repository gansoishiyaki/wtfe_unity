using System.Collections.Generic;

namespace Domain
{
    public class Stage
    {
        public string mapFile;
        public List<StageTeam> teams;

        /// <summary>
        /// 同じグループのチームを取得する
        /// </summary>
        /// <param name="group_id"></param>
        /// <returns></returns>
        public List<StageTeam> groupTeams(int group_id)
        {
            return teams.FindAll(t => t.group_id == group_id);
        }

        /// <summary>
        /// 敵対チームを取得する
        /// </summary>
        /// <param name="group_id"></param>
        /// <returns></returns>
        public List<StageTeam> otherTeams(int group_id)
        {
            return teams.FindAll(t => t.group_id != group_id);
        }
    }
}
