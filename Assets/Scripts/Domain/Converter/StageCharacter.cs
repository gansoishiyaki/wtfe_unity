namespace Domain.Converter
{
    /// <summary>
    /// ステージ変換クラス
    /// </summary>
    static class StageCharacterConverter
    {
        public static StageCharacter ToModel(
            this Resource.StageCharacter stage,
            Resource.Character resource,
            DataStore.Character store
        )
        {
            var chara = new StageCharacter();
            chara.charaBase = store.ToModel(resource);
            chara.initX = stage.pos.x;
            chara.initY = stage.pos.y;

            return chara;
        }
    }
}