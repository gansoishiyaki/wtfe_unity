using System;
using IRepository;

/// <summary>
/// 各層の繋ぎを行うレジストリクラス
/// ベーシックパターン
/// Webの場合は別のレジストリを使う
/// </summary>
public class Registory
{
    public ICharacterService chara;
    public IMissionService mission;

    public Registory(
        IResource resource,
        DataStore.JSON.Handler store
    )
    {
        var storeChara = new DataStore.JSON.CharacterRepository(store);
        chara = new CharacterService(resource, storeChara);

        mission = new MissionService(resource, storeChara);
    }
}
