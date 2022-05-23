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
            IRepository.DataStore.ICharacter storeChara
        )
        {
            var team = new StageTeam();
            team.isPlayer = resourceStage.is_player;
            team.characters = resourceStage.charas.ConvertAll(
                c => c.ToModel(resource.Characters()[c.id], storeChara.Get(c.id))
            );
            
            return team;
        }
    }
}