namespace Domain.Converter
{
    /// <summary>
    /// ステージ変換クラス
    /// </summary>
    static class StageConverter
    {
        public static Stage ToModel(
            this Resource.Stage resource
        )
        {
            var stage = new Stage();
            stage.id = resource.id;
            stage.name = resource.name;
            stage.mapFile = resource.map;

            return stage;
        }
    }
}