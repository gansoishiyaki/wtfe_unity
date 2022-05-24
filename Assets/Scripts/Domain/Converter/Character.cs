namespace Domain.Converter
{
    /// <summary>
    /// キャラクター変換クラス
    /// </summary>
    static class CharacterConverter
    {
        /// <summary>
        /// ストアとリソースからキャラクター作成
        /// </summary>
        /// <param name="store"></param>
        /// <param name="resource"></param>
        /// <returns></returns>
        public static Character ToModel(this DataStore.Character store, Resource.Character resource)
        {
            var chara = new Character();
            chara.id = resource.id;
            chara.level = store.level;
            chara.name = store.name;
            chara.maxhp = store.hp;
            chara.hp = store.maxhp;
            chara.atk = store.atk;
            chara.def = store.def;
            chara.teh = store.teh;
            chara.spd = store.spd;
            chara.luk = store.luk;
            chara.move = store.move;
            chara.conducting = store.conducting;
            chara.moveType = resource.move_type.ToEnum(MoveType.walk);
            chara.attributes = resource
                .attributes
                .ConvertAll(a => a.ToEnum(CharacterAttribute.none))
                .FindAll(a => a != CharacterAttribute.none);

            return chara;
        }

        public static Character forStageCharacter(this Resource.Character resource, Resource.StageCharacter stageCharacter)
        {
            var chara = new Character();
            chara.id = resource.id;
            chara.name = resource.name;
            chara.moveType = resource.move_type.ToEnum(MoveType.walk);
            chara.attributes = resource
                .attributes
                .ConvertAll(a => a.ToEnum(CharacterAttribute.none))
                .FindAll(a => a != CharacterAttribute.none);

            chara.level = resource.enemy.level;
            chara.maxhp = resource.enemy.maxhp;
            chara.hp = resource.enemy.hp == 0 ? chara.maxhp : resource.enemy.hp;
            chara.atk = resource.enemy.atk;
            chara.def = resource.enemy.def;
            chara.teh = resource.enemy.teh;
            chara.spd = resource.enemy.spd;
            chara.luk = resource.enemy.luk;
            chara.move = resource.move;
            chara.conducting = resource.enemy.conducting;

            if (stageCharacter.has_state)
            {
                chara.level = stageCharacter.state.level;
                chara.maxhp = stageCharacter.state.maxhp;
                chara.hp = stageCharacter.state.hp == 0 ? chara.maxhp : stageCharacter.state.hp;
                chara.atk = stageCharacter.state.atk;
                chara.def = stageCharacter.state.def;
                chara.teh = stageCharacter.state.teh;
                chara.spd = stageCharacter.state.spd;
                chara.luk = stageCharacter.state.luk;
                chara.conducting = stageCharacter.state.conducting;
            }

            return chara;
        }

        /// <summary>
        /// リソースからストアデータへの変換
        /// </summary>
        /// <param name="res"></param>
        /// <returns></returns>
        public static DataStore.Character ToStore(this Resource.Character res)
        {
            var chara = new DataStore.Character();

            // 各パラメータの初期値取得
            chara.id = res.id;
            chara.level = res.level;
            chara.name = res.name;
            chara.maxhp = res.maxhp;
            chara.hp = res.maxhp;
            chara.atk = res.atk;
            chara.def = res.def;
            chara.teh = res.teh;
            chara.spd = res.spd;
            chara.luk = res.luk;
            chara.move = res.move;
            chara.conducting = res.conducting;

            return chara;
        }
    }
}
