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
            IRepository.DataStore.ICharacter storeChara,
            DataStore.Team team
        )
        {
            var stage = new Stage();
            stage.mapFile = $"{Config.MapDir}/{resourceStage.map}";

            // 現在のチーム取得
            stage.teams = resourceStage.teams.ConvertAll(
                t => t.ToModel(resource, storeChara, team)
            );
            return stage;
        }
    }
}