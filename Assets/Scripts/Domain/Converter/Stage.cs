using System.Collections.Generic;
namespace Domain.Converter
{
    /// <summary>
    /// ステージ変換クラス
    /// </summary>
    static class StageConverter
    {
        public static Stage ToModel(
            this Resource.Stage resourceStage,
            IRepository.IResource resource,
            IRepository.DataStore.ICharacter storeChara
        )
        {
            var stage = new Stage();
            stage.mapFile = $"{Config.MapDir}/{resourceStage.map}";

            stage.teams = resourceStage.teams.ConvertAll(t => t.ToModel(resource, storeChara));
            return stage;
        }
    }
}