using System;

namespace Domain.Converter
{
    /// <summary>
    /// ステージ変換クラス
    /// </summary>
    static class StageTeamConverter
    {
        public static StageTeam ToModel(
            this Resource.StageTeam resourceStage,
            IRepository.IResource resource,
            IRepository.DataStore.ICharacter storeCharacter,
            DataStore.Team playerTeam
        )
        {
            var team = new StageTeam();
            team.isPlayer = resourceStage.is_player;
            team.group_id = resourceStage.group_id;
            if (team.group_id == 0)
                team.group_id = int.MaxValue.RandomInt();

            var count = 0;
            team.characters = resourceStage.charas.ConvertAll(c =>
            {
                // 固定値が存在する、またはプレイヤーチーム以外の場合
                if (c.has_state || !team.isPlayer)
                {
                    // リソースからキャラ生成
                    var resourceChara = resource.Characters()[c.id];
                    return c.WithStaticState(resourceChara);
                }
                else
                {
                    // カウントオーバー時は終了
                    if (playerTeam.characters.Count == count)
                        return null;

                    // リソースとデータストアからキャラ生成
                    var id = playerTeam.characters[count];
                    var storeChara = storeCharacter.Get(id);
                    var resourceChara = resource.Characters()[id];
                    count++;
                    return c.WithPlayer(resourceChara, storeChara);
                }
            }).FindAll(c => c != null);
            
            return team;
        }
    }
}