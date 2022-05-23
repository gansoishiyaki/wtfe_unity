namespace Domain.Converter
{
    /// <summary>
    /// ステージ変換クラス
    /// </summary>
    static class FieldCharacterConverter
    {
        public static Field.Character ToModel(
            this Resource.StageCharacter stage,
            Resource.Character resource,
            DataStore.Character store
        )
        {
            var chara = new Field.Character();
            chara.charaBase = store.ToModel(resource);
            chara.initX = stage.pos.x;
            chara.initY = stage.pos.y;

            return chara;
        }
    }
}