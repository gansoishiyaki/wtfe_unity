namespace Domain.Converter
{
    /// <summary>
    /// ステージ変換クラス
    /// </summary>
    static class FieldTeamConverter
    {
        public static Field.Team ToModel(
            this Resource.StageTeam resourceStage,
            IRepository.IResource resource,
            IRepository.DataStore.ICharacter storeChara
        )
        {
            var team = new Field.Team();
            team.isPlayer = resourceStage.is_player;
            team.characters = resourceStage.charas.ConvertAll(
                c => c.ToModel(resource.Characters()[c.id], storeChara.Get(c.id))
            );
            
            return team;
        }
    }
}