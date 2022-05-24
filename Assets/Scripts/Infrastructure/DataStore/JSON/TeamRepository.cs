using IRepository.DataStore;

namespace DataStore.JSON
{
    /// <summary>
    /// キャラクターデータを扱うクラス
    /// </summary>
    public class TeamRepository : ITeam
    {
        private Handler handler;

        public TeamRepository(Handler handler)
        {
            this.handler = handler;
        }

        Team ITeam.Get(string id)
        {
            return handler.teams[id];
        }

        void ITeam.Set(Team team)
        {
            handler.teams[team.id] = team;
        }

        bool ITeam.Exist(string id)
        {
            return handler.teams.ContainsKey(id);
        }
    }
}